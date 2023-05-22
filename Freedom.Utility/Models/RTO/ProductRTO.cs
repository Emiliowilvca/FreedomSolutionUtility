using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    [Obsolete("use product full", true)]

    public class ProductRTO : IProductRTO
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string CodeProvider { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }

        public string SubGroup { get; set; }

        public string Brand { get; set; }

        public string Measure { get; set; }

        public decimal Weight { get; set; }

        public bool PayTax { get; set; }

        public decimal TaxRate { get; set; }

        public decimal MaxDiscount { get; set; }

        public decimal QuantityBox { get; set; }

        public bool AlterStock { get; set; }

        public bool IsService { get; set; }

        public bool ProCheck { get; set; }

        public decimal SalePrice { get; set; }

        public int MoneyId { get; set; }

        public string Symbol { get; set; }

        public string MoneyName { get; set; }

        public int DecimalPlaces { get; set; }

        public int ShopId { get; set; }

        public decimal StockQuantity { get; set; }

        public DateTime Expiration { get; set; }

        public string UrlPrimaryImage { get; set; }

        public string UrlSecondaryImage { get; set; }
    }
}