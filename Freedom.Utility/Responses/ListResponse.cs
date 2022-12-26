using System.Collections.Generic;
using System.Net;

namespace Freedom.Utility.Responses
{
    public class ListResponse<T>
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public List<T> Collection { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}