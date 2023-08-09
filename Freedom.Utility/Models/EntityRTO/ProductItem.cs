using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ProductItem : IProductItem
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public decimal MaxDiscount { get; set; }

        public decimal QuantityBox { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SalePrice { get; set; }

        public string Lote { get; set; }

        public int MoneyId { get; set; }

        public int MeasureId { get; set; }

        public decimal StockQuantity { get; set; }

        public decimal TaxRate { get; set; }

        public string UrlPrimaryImage { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }
    }
}