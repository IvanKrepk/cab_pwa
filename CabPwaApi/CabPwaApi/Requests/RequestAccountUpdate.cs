// Requests/RequestAccountUpdate.cs
using System.Text.Json.Serialization;

namespace CabPwaApi.Requests
{
    public class RequestAccountUpdate
    {
        [JsonPropertyName("account_number")]
        public int account_number {  get; set; }

        [JsonPropertyName("account_name_new")]
        public string account_name_new { get; set; } = string.Empty;
        
        [JsonPropertyName("password_new")]
        public string password_new { get; set; } = string.Empty;
    }

}
