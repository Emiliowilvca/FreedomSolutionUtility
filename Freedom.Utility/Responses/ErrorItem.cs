using System.Text.Json.Serialization;

namespace Freedom.Utility.Responses
{
    public class ErrorItem
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonPropertyName("errorState")]
        public object ErrorState { get; set; }
    }
}