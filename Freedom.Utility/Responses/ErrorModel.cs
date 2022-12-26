using System.Text.Json.Serialization;

namespace Freedom.Utility.Responses
{
    public class ErrorModel
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("resx_code")]
        public string ResxCode { get; set; }

        [JsonPropertyName("message")]
        public string Menssage { get; set; }

        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }
    }
}