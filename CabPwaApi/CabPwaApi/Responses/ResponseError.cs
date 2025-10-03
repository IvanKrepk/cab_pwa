using System.Text.Json.Serialization;

namespace CabPwaApi.Responses
{
    public class ResponseError: Response
    {
        [JsonPropertyName("message")]
        public string? message { get; set; }
    }
}
