// Responses/ResponseLoginSuccess.cs
using System.Text.Json.Serialization;

namespace CabPwaApi.Responses
{
    public class ResponseLoginSuccess: Response
    {
        [JsonPropertyName("web_login")]
        public string? web_login { get; set; }

        [JsonPropertyName("account_name")]
        public string? account_name { get; set; }

        [JsonPropertyName("card_code")]
        public int? card_code { get; set; }

        [JsonPropertyName("card_number")]
        public int? card_number { get; set; }

        [JsonPropertyName("card_full_number")]
        public string? card_full_number { get; set; }

        [JsonPropertyName("emitent_code")]
        public int? emitend_code { get; set; }

        [JsonPropertyName("account_number")]
        public int? account_number { get; set; }

        [JsonPropertyName("token")]
        public string? token { get; set; }
    }
}
