// Requests/LoginRequest.cs
using System.Text.Json.Serialization;

namespace CabPwaApi.Requests
{
    public class LoginRequest
    {
        [JsonPropertyName("web_login")]
        public string web_login { get; set; } = string.Empty;

        [JsonPropertyName("password")]
        public string password { get; set; } = string.Empty;
    }
}
