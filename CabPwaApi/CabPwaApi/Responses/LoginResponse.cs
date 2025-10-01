// Responses/LoginResponse.cs
using System.Text.Json.Serialization;

namespace CabPwaApi.Responses
{
    public class LoginResponse
    {
        [JsonPropertyName("message")]
        public string? message {  get; set; }
    }
}
