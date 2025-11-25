using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

using Blazored.LocalStorage;

using CxShared.Auth;

using static System.Net.WebRequestMethods;
//using static CxClie.Admin.Gxlogin;

namespace CxClie.Services
{
    public interface IFrontendLoginService
    {
        Task<bool> LoginAsync(string apiKey, LoginModel loginModel);
        Task CustLogout();
        Task GxLogout();
        //Task LogoutAsync(string apiKey);
    }

    public class FrontendLoginService : IFrontendLoginService
    {
        private readonly AppState _appState;
        private readonly ILocalStorageService _localStorage;
        private readonly MyMultAuthStateProvider _authProvider;
        private readonly IDynamicApiClientService _dynClient;
        private readonly IHttpClientFactory _clientFactorer;

        public FrontendLoginService(
            AppState appState,
            ILocalStorageService localStorage,
            MyMultAuthStateProvider authProvider,
            IDynamicApiClientService dynClient,
            IHttpClientFactory clientFactorer)
        {
            _appState = appState;
            _localStorage = localStorage;
            _authProvider = authProvider;
            _dynClient = dynClient;
            _clientFactorer = clientFactorer;
        }
        public async Task<bool> LoginAsync(string apiKey, LoginModel loginModel)
        {
            try
            {
                var payload = new
                {
                    Username = loginModel.UsernameOrEmail,
                    loginModel.UsernameOrEmail,
                    loginModel.Password,
                    loginModel.Idorg,
                    loginModel.Idagt,
                    loginModel.Sigle,
                    loginModel.Raison,
                    loginModel.Nom,
                    loginModel.Pnom,
                    loginModel.BackendUrl
                };

                var json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpClient client;
                string requestUrl;

                if (apiKey == "CustApi")
                {
                    // dynamic client
                    _dynClient.SetBaseUrl(loginModel.BackendUrl);
                    client = _dynClient.GetClient();
                    requestUrl = "api/lgauth/login"; // baseUrl already set
                }
                else if (apiKey == "GxApi")
                {
                    // static client from DI
                    client = _clientFactorer.CreateClient("ApiGxClient");
                    requestUrl = "api/gxauth/gxlogin"; // baseUrl from Program.cs
                }
                else
                {
                    throw new InvalidOperationException($"Unknown apiKey: {apiKey}");
                }

                var response = await client.PostAsync(requestUrl, content);
                var raw = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"[FrontendLoginService] Raw response: {raw}");

                if (!response.IsSuccessStatusCode)
                    return false;

                var result = JsonSerializer.Deserialize<LoginResult>(raw,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (result != null && result.Succeeded)
                {
                    // Persist tokens separately per API
                    if (!string.IsNullOrEmpty(result.Atoken))
                        await _localStorage.SetItemAsync($"{apiKey}_AccessToken", result.Atoken);

                    if (!string.IsNullOrEmpty(result.Rtoken))
                        await _localStorage.SetItemAsync($"{apiKey}_RefreshToken", result.Rtoken);

                    await _localStorage.SetItemAsync($"{apiKey}_BackendUrl", loginModel.BackendUrl);

                    result.IsAuthenticated = !string.IsNullOrEmpty(result.Atoken);
                    _appState.SetLogin(apiKey, result);

                    // Update AuthenticationStateProvider
                    if (_authProvider is MyMultAuthStateProvider provider)
                    {
                        if (apiKey == "CustApi")
                            await provider.SetCustApiTokenAsync(result.Atoken);
                        else if (apiKey == "ApiGx")
                            await provider.SetGxApiTokenAsync(result.Atoken);
                    }

                    return result.IsAuthenticated;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FrontendLoginService] Exception: {ex}");
                return false;
            }
        }


        public async Task CustLogout()
        {
            // Clear token in the provider
            await _authProvider.SetCustApiTokenAsync(string.Empty);
            // Clear persisted token if you’re storing it
            await _localStorage.RemoveItemAsync("CustApiToken");
            // Clear AppState entry
            _appState.ClearLogin("CustApi");
        }
        public async Task GxLogout()
        {
            await _authProvider.SetGxApiTokenAsync(string.Empty);
            await _localStorage.RemoveItemAsync("StaticApiToken");
            _appState.ClearLogin("StaticApi");
        }
        //public async Task LogoutAsync(string apiKey)
        //{
        //    await _localStorage.RemoveItemAsync("accessToken");
        //    await _localStorage.RemoveItemAsync("refreshToken");
        //    await _localStorage.RemoveItemAsync("backendUrl");
        //    _appState.ClearLogin(apiKey);
        //}
    }
    public class ApiCustAuthorizationHandler : DelegatingHandler
    {
        private readonly ILocalStorageService _storage;
        private readonly MyMultAuthStateProvider _authProvider;

        public ApiCustAuthorizationHandler(MyMultAuthStateProvider authProvider)
        {
            _authProvider = authProvider;
        }
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var token = _authProvider.GetCustApiToken(); ;

            if (!string.IsNullOrWhiteSpace(token))
            {
                if (request.Headers.Authorization == null && !string.IsNullOrWhiteSpace(token))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }

    public class ApiGxAuthorizationHandler : DelegatingHandler
    {
        private readonly MyMultAuthStateProvider _authProvider;

        public ApiGxAuthorizationHandler(MyMultAuthStateProvider authProvider)
        {
            _authProvider = authProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _authProvider.GetGxApiToken();
            if (!string.IsNullOrEmpty(token))
            {
                if (request.Headers.Authorization == null && !string.IsNullOrWhiteSpace(token))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }

    public interface IDynamicApiClientService
    {
        void SetBaseUrl(string baseUrl);
        HttpClient GetClient();
    }

    public class DynamicApiClientService : IDynamicApiClientService
    {
        private readonly IHttpClientFactory _factory;
        private readonly ILocalStorageService _localStorage;
        private string? _baseUrl;

        public DynamicApiClientService(IHttpClientFactory factory, ILocalStorageService localStorage)
        {
            _factory = factory;
            _localStorage = localStorage;
        }

        public void SetBaseUrl(string baseUrl)
        {
            _baseUrl = baseUrl.TrimEnd('/');
        }

        public HttpClient GetClient()
        {
            if (string.IsNullOrEmpty(_baseUrl))
                throw new Exception("API base URL not set. Call SetBaseUrl() first.");

            var client = _factory.CreateClient("ApiCustClient");

            client.BaseAddress = new Uri(_baseUrl);

            return client;
        }
    }
}
//public async Task<bool> LoginAsync(string apiKey, LoginModel loginModel)
//{
//    try
//    {
//        var payload = new
//        {
//            loginModel.UsernameOrEmail,
//            //loginModel.Username,
//            loginModel.Password,
//            loginModel.Idorg,
//            loginModel.Idagt,
//            loginModel.Sigle,
//            loginModel.Raison,
//            loginModel.Nom,
//            loginModel.Pnom,
//            loginModel.BackendUrl
//        };
//        //Console.WriteLine($"Here1 : {json}");
//        var json = JsonSerializer.Serialize(payload);
//        var content = new StringContent(json, Encoding.UTF8, "application/json");
//        Console.WriteLine($"Here2 : {json}");

//        // Configure dynamic client with backend URL
//        _dynClient.SetBaseUrl(loginModel.BackendUrl);
//        var client = _dynClient.GetClient();

//        var requestUrl = $"api/lgauth/login"; // baseUrl already set in client

//        var response = await client.PostAsync(requestUrl, content);
//        var raw = await response.Content.ReadAsStringAsync();
//        Console.WriteLine($"[FrontendLoginService] Raw response: {raw}");

//        if (!response.IsSuccessStatusCode)
//        {
//            return false;
//        }

//        var result = JsonSerializer.Deserialize<LoginResult>(raw,
//            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

//        if (result != null && result.Succeeded)
//        {
//            // Persist tokens for later use
//            if (!string.IsNullOrEmpty(result.Atoken))
//                await _localStorage.SetItemAsync("accessToken", result.Atoken);

//            if (!string.IsNullOrEmpty(result.Rtoken))
//                await _localStorage.SetItemAsync("refreshToken", result.Rtoken);

//            await _localStorage.SetItemAsync("backendUrl", loginModel.BackendUrl);
//            // Mark IsAuthenticated based on your model
//            result.IsAuthenticated = result.Succeeded && !string.IsNullOrEmpty(result.Atoken);
//            _appState.SetLogin(apiKey, result);
//            return result.IsAuthenticated;
//        }
//        return false;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"[FrontendLoginService] Exception: {ex}");
//        return false;
//    }
//}

