using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace Sistema.Web.Auth
{
    public class AuthenticationProviderJWT : AuthenticationStateProvider, ILoginServicio
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _httpClient;
        private readonly AuthenticationState _anonymous;
        private int _idUsuario;
        private string _nombreUsuario;
        private string _rolUsuario;
        private string _nombrePublico;

        public AuthenticationProviderJWT(ILocalStorageService localStorage, HttpClient httpClient)
        {
            _localStorage = localStorage;
            _httpClient = httpClient;

            _anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");

            if (string.IsNullOrEmpty(token) || !IsTokenValid(token))
            {
                return _anonymous;
            }

            // Establecer el token en el encabezado de autorización de HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Crear una identidad a partir del token JWT
            var claims = ParseClaimsFromJwt(token);
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwtAuthType"));

            // Asignar claims globales (idUsuario, nombreUsuario, rolUsuario)
            SetUserInfo(claims);

            return new AuthenticationState(user);
        }

        private bool IsTokenValid(string token)
        {
            var claims = ParseClaimsFromJwt(token);
            var expClaim = claims.FirstOrDefault(c => c.Type == "exp");
            if (expClaim != null && long.TryParse(expClaim.Value, out var exp))
            {
                var expDate = DateTimeOffset.FromUnixTimeSeconds(exp).UtcDateTime;
                return expDate > DateTime.UtcNow;
            }
            return false;
        }

        public async Task LoginAsync(string token)
        {
            // Guardar el token en LocalStorage
            await _localStorage.SetItemAsync("authToken", token);

            // Establecer el token en el encabezado de autorización de HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Notificar al sistema de Blazor que el estado de autenticación ha cambiado
            var claims = ParseClaimsFromJwt(token);
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwtAuthType"));

            SetUserInfo(claims);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public async Task LogoutAsync()
        {
            // Eliminar el token de LocalStorage
            await _localStorage.RemoveItemAsync("authToken");

            // Eliminar el encabezado de autorización del HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = null;

            // Notificar al sistema de Blazor que el estado de autenticación ha cambiado
            NotifyAuthenticationStateChanged(Task.FromResult(_anonymous));
        }

        private void SetUserInfo(IEnumerable<Claim> claims)
        {
            var idUsuarioClaim = claims.FirstOrDefault(c => c.Type == "idusuario");
            if (idUsuarioClaim != null && int.TryParse(idUsuarioClaim.Value, out int idUsuario))
            {
                _idUsuario = idUsuario;
                _nombreUsuario = claims.FirstOrDefault(c => c.Type == "nombre")?.Value ?? "Desconocido";
                _rolUsuario = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value ?? "SinRol";
                _nombrePublico = claims.FirstOrDefault(c => c.Type == "nombrePublico")?.Value ?? "Sin Nombre Publico";
            }
        }

        public int GetIdUsuario()
        {
            return _idUsuario;
        }

        public string GetNombreUsuario()
        {
            return _nombreUsuario;
        }

        public string GetNombrePublico()
        {
            return _nombrePublico;
        }

        public string GetRolUsuario()
        {
            if (string.IsNullOrEmpty(_rolUsuario))
            {
                return "SinRol";
            }
            return _rolUsuario;
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
