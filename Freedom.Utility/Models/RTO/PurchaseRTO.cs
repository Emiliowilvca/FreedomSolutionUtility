using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class PurchaseRTO : IPurchaseRTO
    {
        public string ProviderName { get; set; }

        public decimal TotalRetention { get; set; }

        public bool RetentionExport { get; set; }

        public string OperationTypeName { get; set; }

        public string MoneyName { get; set; }

        public string ShopName { get; set; }

        public string BoxName { get; set; }

        public string CarrierName { get; set; }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public long InvoiceNum { get; set; }

        public int ProviderId { get; set; }

        public int OperationTypeId { get; set; }

        public int MoneyId { get; set; }

        public Guid UserId { get; set; }

        public int ShopId { get; set; }

        public int BoxId { get; set; }

        public int CarrierId { get; set; }

        public decimal Total { get; set; }

        public decimal TotalTax { get; set; }

        public decimal ImportExpence { get; set; }

        public bool ItsImport { get; set; }

        public decimal Exchange { get; set; }

        public bool Status { get; set; }

        public string Note { get; set; }

        public string Timbrado { get; set; }

        public string ProviderRuc { get; set; }

        public string MoneyISO4217 { get; set; }

        public string WithholdingConditionSET { get; set; }
    }
}