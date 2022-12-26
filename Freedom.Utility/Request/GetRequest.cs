using Freedom.Utility.RequestBase;
using System;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class GetRequest : IRequestDateRangue, IRequestId, IRequestUserId, IRequestCompanyId
    {
        public int CompanyId { get; set; }

        public int Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime SinceDate { get; set; }

        public DateTime UntilDate { get; set; }
    }
}