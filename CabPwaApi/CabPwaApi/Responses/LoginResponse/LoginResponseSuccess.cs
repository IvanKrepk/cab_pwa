using System.Text.Json.Serialization;

namespace CabPwaApi.Responses.LoginResponse
{
    public class LoginResponseSuccess: Response
    {
        [JsonPropertyName("user_name")]
        public string? user_name { get; set; }

        [JsonPropertyName("display_name")]
        public string? display_name { get; set; }

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
