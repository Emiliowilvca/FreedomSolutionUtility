using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Freedom.Utility.Responses
{
    public class ErrorResponse
    {
        [JsonPropertyName("errors")]
        public List<ErrorModel> ErrorCollection { get; set; } = new List<ErrorModel>();

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("date_error")]
        public DateTime ErrorDate { get; set; }
    }
}