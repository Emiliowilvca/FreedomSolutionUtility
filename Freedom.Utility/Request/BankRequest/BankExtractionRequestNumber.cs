using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request.BankRequest
{
    public class BankExtractionRequestNumber : IRequestNavigate, IRequestCompanyId, IRequestNumRangue
    {
        public int CompanyId { get; set; }

        public int OffSet { get; set; }

        public int Limit { get; set; }
        
        public long SinceNumber { get; set; }

        public long UntilNumber { get; set; }

        public int OperationTypeId { get; set; }

        public int BankAccountId { get; set; }
    }
}