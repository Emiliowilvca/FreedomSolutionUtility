using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class WithholdingTaxExportedRTO : IWithholdingTaxExportedRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int PurchaseId { get; set; }

        public int WithholdingTaxId { get; set; }
    }
}