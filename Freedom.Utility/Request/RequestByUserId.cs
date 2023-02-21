using Freedom.Utility.RequestBase;
using System;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class RequestByUserId : IRequestDateRangue, IRequestUserId, IRequestCompanyId, IRequestNavigate,
                                   IRequestMoneyId
    {
        public DateTime SinceDate { get; set; }

        public DateTime UntilDate { get; set; }

        public int CompanyId { get; set; }

        public int OffSet { get; set; }

        public int Limit { get; set; }

        public int MoneyId { get; set; }

        public Guid UserId { get; set; }
    }
}