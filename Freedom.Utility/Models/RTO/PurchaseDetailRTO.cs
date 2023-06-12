using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class PurchaseDetailRTO : IPurchaseDetailRTO
    {
        public long Id { get; set; }

        public int PurchaseId { get; set; }

        public int ProductId { get; set; }
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxValue { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }
    }
}