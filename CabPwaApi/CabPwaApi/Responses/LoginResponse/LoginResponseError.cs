using System.Text.Json.Serialization;

namespace CabPwaApi.Responses.LoginResponse
{
    public class LoginResponseError: LoginResponse
    {
        [JsonPropertyName("message")]
        public string? message { get; set; }
    }
}
