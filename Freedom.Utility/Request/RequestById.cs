using Freedom.Utility.RequestBase;
using System;

namespace Freedom.Utility.Request
{
    public class RequestById : IRequestDateRangue, IRequestId, IRequestCompanyId, IRequestNavigate,
                               IRequestMoneyId

    {
        public int Id { get; set; }

        public DateTime SinceDate { get; set; }

        public DateTime UntilDate { get; set; }

        public int MoneyId { get; set; }

        public int CompanyId { get; set; }

        public int OffSet { get; set; }

        public int Limit { get; set; }
    }
}