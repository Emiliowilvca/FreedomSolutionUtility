using System.Text.Json.Serialization;

namespace Freedom.Utility.Responses
{
    public class XResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("resultMessage")]
        public string ResultMessage { get; set; }
    }
}