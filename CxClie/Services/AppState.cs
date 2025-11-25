using CxShared.Auth;

namespace CxClie.Services
{
    public class AppState
    {
        // Dictionary keyed by API name (e.g. "Api1", "Api2")
        private readonly Dictionary<string, LoginResult?> _logins = new();

        public event Action? OnChange;

        // Check if a given API is authenticated
        public bool IsAuthenticated(string apiKey)
            => _logins.TryGetValue(apiKey, out var result) && result?.IsAuthenticated == true;

        // Get the full login result for an API
        public LoginResult? GetLogin(string apiKey)
            => _logins.TryGetValue(apiKey, out var result) ? result : null;

        // Set login result for an API
        public void SetLogin(string apiKey, LoginResult result)
        {
            _logins[apiKey] = result;
            NotifyStateChanged();
        }

        // Clear login result for an API
        public void ClearLogin(string apiKey)
        {
            if (_logins.ContainsKey(apiKey))
            {
                _logins.Remove(apiKey);
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
