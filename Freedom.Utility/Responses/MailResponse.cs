using System.Text.Json.Serialization;

namespace Freedom.Utility.Responses
{
    public class MailResponse
    {
        [JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}