using Freedom.Utility.Enums;
using System;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class XRequest : Pagination
    {
        public SearchType Search { get; set; } = SearchType.DateRange;

        public int Id { get; set; }

        public long Skip { get; set; }

        public long Take { get; set; }

        public DateTime SinceDate { get; set; }

        public DateTime UntilDate { get; set; }
    }
}