using System.Net;

namespace Freedom.Utility.Responses
{
    public class EntityResponse<T>
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public T Entity { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}