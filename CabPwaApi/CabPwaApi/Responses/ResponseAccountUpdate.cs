// Responses/ResponseAccountUpdate.cs

using System.Text.Json.Serialization;

namespace CabPwaApi.Responses
{
    public class ResponseAccountUpdate: Response
    {
        [JsonPropertyName("message")]
        public string message { get; set; } = string.Empty;
    }
}
