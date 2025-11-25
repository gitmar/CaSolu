using System.Net.Http.Headers;
using System.Security.Claims;

using System.IdentityModel.Tokens.Jwt;   // for JwtSecurityTokenHandler
using System.Security.Principal;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Authorization;

namespace CxClie.Services
{

    public class MyMultAuthStateProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal _user = new ClaimsPrincipal(new ClaimsIdentity());

        private string? _custApiToken;
        private string? _gxApiToken;

        public string? GetCustApiToken() => _custApiToken;
        public string? GetGxApiToken() => _gxApiToken;

        public async Task SetCustApiTokenAsync(string token)
        {
            _custApiToken = token;
            await UpdateUserClaimsAsync();
        }

        public async Task SetGxApiTokenAsync(string token)
        {
            _gxApiToken = token;
            await UpdateUserClaimsAsync();
        }

        private async Task UpdateUserClaimsAsync()
        {
            var identities = new List<ClaimsIdentity>();

            if (!string.IsNullOrEmpty(_custApiToken))
                identities.Add(new ClaimsIdentity(DecodeJwtClaims(_custApiToken), "CustApi"));

            if (!string.IsNullOrEmpty(_gxApiToken))
                identities.Add(new ClaimsIdentity(DecodeJwtClaims(_gxApiToken), "GxApi"));

            _user = new ClaimsPrincipal(identities);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
            => Task.FromResult(new AuthenticationState(_user));

        private IEnumerable<Claim> DecodeJwtClaims(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.ReadJwtToken(token);
            return jwt.Claims;
        }
    }
    //public class MyMultAuthStateProvider : AuthenticationStateProvider
    //{
    //    private ClaimsPrincipal _user = new ClaimsPrincipal(new ClaimsIdentity());

    //    // Store tokens or user info for both APIs
    //    private string _api1Token;
    //    private string _api2Token;
    //    public string? GetApi1Token() => _api1Token;
    //    public string? GetApi2Token() => _api2Token;
    //    public async Task SetApi1TokenAsync(string token)
    //    {
    //        _api1Token = token;
    //        // Update user claims as needed per
    //        await UpdateUserClaimsAsync();
    //    }

    //    public async Task SetApi2TokenAsync(string token)
    //    {
    //        _api2Token = token;
    //        // Update user claims as needed per API2
    //        await UpdateUserClaimsAsync();
    //    }

    //    private async Task UpdateUserClaimsAsync()
    //    {
    //        // Combine claims from tokens or fetch from APIs
    //        var identity = new ClaimsIdentity();

    //        if (!string.IsNullOrEmpty(_api1Token))
    //        {
    //            identity.AddClaims(DecodeJwtClaims(_api1Token));
    //        }
    //        if (!string.IsNullOrEmpty(_api2Token))
    //        {
    //            identity.AddClaims(DecodeJwtClaims(_api2Token));
    //        }

    //        _user = new ClaimsPrincipal(identity);
    //        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
    //    }

    //    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    //    {
    //        return Task.FromResult(new AuthenticationState(_user));
    //    }
    //    private IEnumerable<Claim> DecodeJwtClaims(string token)
    //    {
    //        var handler = new JwtSecurityTokenHandler();
    //        var jwt = handler.ReadJwtToken(token);
    //        return jwt.Claims;
    //    }
    //}
    //public class TokenAwareClientManager
    //{
    //    private readonly MyMultAuthStateProvider _authProvider;

    //    public TokenAwareClientManager(MyMultAuthStateProvider authProvider)
    //    {
    //        _authProvider = authProvider;
    //    }

    //    public HttpClient GetApi1Client()
    //    {
    //        var client = new HttpClient();
    //        var token = _authProvider.GetApi1Token();
    //        if (!string.IsNullOrEmpty(token))
    //        {
    //            client.DefaultRequestHeaders.Authorization =
    //                new AuthenticationHeaderValue("Bearer", token);
    //        }
    //        return client;
    //    }

    //    public HttpClient GetApi2Client()
    //    {
    //        var client = new HttpClient();
    //        var token = _authProvider.GetApi2Token();
    //        if (!string.IsNullOrEmpty(token))
    //        {
    //            client.DefaultRequestHeaders.Authorization =
    //                new AuthenticationHeaderValue("Bearer", token);
    //        }
    //        return client;
    //    }
    //}
}
