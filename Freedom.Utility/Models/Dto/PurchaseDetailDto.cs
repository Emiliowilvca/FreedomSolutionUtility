using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    public class PurchaseDetailDto : IPurchaseDetail
    {
        public long Id { get; set; }

        public int PurchaseId { get; set; }

        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxValue { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }

        public CostPriceDto CostPriceDto { get; set; }

        public IEnumerable<SalePriceDto> SalePriceCollection { get; set; }
    }
}