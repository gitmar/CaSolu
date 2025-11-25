namespace CxClie.Services
{
    public class Api1AuthorizationHandler : DelegatingHandler
    {
        private readonly MyMultAuthStateProvider _authProvider;

        public Api1AuthorizationHandler(MyMultAuthStateProvider authProvider)
        {
            _authProvider = authProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _authProvider.GetApi1Token();
            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
    

}
