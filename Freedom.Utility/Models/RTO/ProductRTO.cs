using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    /// <summary>
    /// product model with few properties
    /// </summary>
    public class ProductRTO : IProductRTO
    {
        public int Id { get; set; } 

        public string Code { get; set; }

        public string Name { get; set; }

        public decimal SalePrice { get; set; }

        public decimal CostPrice { get; set; }

        public int MoneyId { get; set; }

        public decimal Exchange { get; set; }

        public int ShopId { get; set; }

        public decimal StockQuantity { get; set; }

        public bool PayTax { get; set; }

        public decimal TaxRate { get; set; }

        public decimal MaxDiscount { get; set; }

        public bool AlterStock { get; set; }

        public bool IsService { get; set; }

        public bool ProCheck { get; set; }
    }
}