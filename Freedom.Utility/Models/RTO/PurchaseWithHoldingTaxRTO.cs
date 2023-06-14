using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class PurchaseWithHoldingTaxRTO : IPurchaseWithHoldingTaxRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int PurchaseId { get; set; }

        public DateTime DateRetention { get; set; }

        public string MoneyISO4217 { get; set; }

        public string Condition { get; set; }

        public string TaxPayerStatus { get; set; }

        public int TipoComprobanteId { get; set; }

        public bool IsRetentionIVA { get; set; }

        public bool IsRetentionRenta { get; set; }

        public string ConceptRetentionRenta { get; set; }

        public string ConceptRetentionTaxIva { get; set; }

        public decimal ChangeType { get; set; }

        public decimal TotalInvoice { get; set; }

        public decimal TotalIva5 { get; set; }

        public decimal TotalIva10 { get; set; }

        public decimal TotalExenta { get; set; }

        public decimal TaxIva5 { get; set; }

        public decimal TaxIva10 { get; set; }

        public decimal TaxTotal { get; set; }

        public decimal RetentionPercentIva5 { get; set; }

        public decimal RetentionPercentIva10 { get; set; }

        public decimal RetentionPercentRenta { get; set; }

        public decimal RetentionIva5 { get; set; }

        public decimal RetentionIva10 { get; set; }

        public decimal RetentionRenta { get; set; }

        public decimal RetentionCabeza { get; set; }

        public decimal RetentionTonelada { get; set; }

        public decimal RetentionTotalGeneral { get; set; }
    }
}