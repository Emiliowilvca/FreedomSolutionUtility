using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ProductItem : IProductItem
    {
        public Guid RowId { get; set; }

        public int ProductId { get; set; }

        public bool IsPopulate { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal MaxDiscount { get; set; }

        public decimal PriceCost { get; set; }

        public decimal PriceSale { get; set; }

        public string Lote { get; set; }

        public int MoneyId { get; set; }

        public decimal StockQuantity { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxValue { get; set; }

        public decimal Discount { get; set; }

        public string UrlPrimaryImage { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }
    }
}