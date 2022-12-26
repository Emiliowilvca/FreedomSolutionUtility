using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Freedom.Utility.Responses
{
    public class ResponsePagination<T>
    {
        [JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("resourceKey")]
        public string ResourceKey { get; set; }

        [JsonPropertyName("result")]
        public List<T> Result { get; set; }

        [JsonPropertyName("totalItems")]
        public long TotalItems { get; set; }

        /// <summary>
        /// Total pages (TotalItems / ItemsPerPage)
        /// </summary>
        [JsonPropertyName("totalPages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// Total de items que devuelve la consulta
        /// </summary>
        /// <value></value>
        [JsonPropertyName("filterItems")]
        public long FilterItems { get; set; }
    }
}