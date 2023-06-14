using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class PurchaseInstallmentRTO : IPurchaseInstallmentRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int PurchaseId { get; set; }

        public int FeeIndex { get; set; }

        public int ProviderId { get; set; }

        public decimal Capital { get; set; }

        public decimal Interest { get; set; }

        public decimal Feesvalue { get; set; }

        public int MoneyId { get; set; }

        public bool Status { get; set; }

        public DateTime Expirate { get; set; }

        public decimal Exchange { get; set; }

    }
}