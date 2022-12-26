using System.Collections.Generic;

namespace Freedom.Utility.Responses
{
    public class PagedResult<T>
    {
        public int TotalCount { get; set; }

        public List<T> ResultQuery { get; set; }
    }
}