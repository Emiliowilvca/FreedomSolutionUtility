using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request.BankRequest
{
    public class BankExtractionRequest : IRequestCompanyId, IRequestDateIntergerRangue,
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