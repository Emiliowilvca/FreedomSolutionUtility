using Freedom.Utility.RequestBase;
using System;

namespace Freedom.Utility.Request.BankRequest
{
    public class BankDepositRequest : IRequestCompanyId, IRequestDateIntergerRangue, 
                                       IRequestOperationTypeId, IRequestNavigate
    {
        public int CompanyId { get; set; }

        public long SinceDate { get; set; }

        public long UntilDate { get; set; }

        public int OperationTypeId { get; set; }

        public int BankAccountId { get; set; }

        public int OffSet { get; set; }
        
        public int Limit { get; set; }
    }
}