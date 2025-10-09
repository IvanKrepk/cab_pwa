// Responses/ResponseAccountUpdate.cs
using System.Text.Json.Serialization;

namespace CabPwaApi.Responses
{
    public class ResponseAccountUpdate: Response
    {
        [JsonPropertyName("message")]
        public string message { get; set; } = string.Empty;

        [JsonPropertyName("account_name_new")]
        public string? account_name_new { get; set; }
    }
}
