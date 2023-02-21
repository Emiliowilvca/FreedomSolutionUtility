using Freedom.Utility.RequestBase;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class RequestByIds : IRequestDateRangue, IRequestIds, IRequestCompanyId, IRequestNavigate,
                                IRequestMoneyId
    {
        public List<int> Ids { get; set; }

        public DateTime SinceDate { get; set; }

        public DateTime UntilDate { get; set; }

        public int MoneyId { get; set; }

        public int CompanyId { get; set; }

        public int OffSet { get; set; }

        public int Limit { get; set; }
    }
}