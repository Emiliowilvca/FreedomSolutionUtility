using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class ProductRTO : IProductRTO
    {
        public bool AlterStock { get; set; }
        public string Code { get; set; }
        public int DecimalPlaces { get; set; }
        public int Id { get; set; }
        public bool IsService { get; set; }
        public decimal MaxDiscount { get; set; }
        public int MoneyId { get; set; }
        public string Name { get; set; }
        public bool PayTax { get; set; }
        public bool ProCheck { get; set; }
        public decimal SalePrice { get; set; }
        public int ShopId { get; set; }
        public decimal StockQuantity { get; set; }
        public string Symbol { get; set; }
        public decimal TaxRate { get; set; }
    }
}