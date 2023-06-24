namespace Freedom.Utility.Models.InterfaceRTO
{

    [Obsolete("use product full", true)]
    public interface IProductRTO
    {
        int Id { get; set; }

        string Code { get; set; }

        string CodeProvider { get; set; }

        string Barcode { get; set; }

        string Name { get; set; }

        string Group { get; set; }

        string SubGroup { get; set; }

        string Brand { get; set; }

        string Measure { get; set; }

        decimal Weight { get; set; }

        bool PayTax { get; set; }

        decimal TaxRate { get; set; }

        decimal MaxDiscount { get; set; }

        decimal QuantityBox { get; set; }

        bool AlterStock { get; set; }

        bool IsService { get; set; }

        bool ProCheck { get; set; }

        //price sale
        decimal SalePrice { get; set; }

        //money

        int MoneyId { get; set; }

        string Symbol { get; set; }

        string MoneyName { get; set; }

        int DecimalPlaces { get; set; }

        //stock
        int ShopId { get; set; }

        decimal StockQuantity { get; set; }

        DateTime Expiration { get; set; }

        string UrlPrimaryImage { get; set; }

        string UrlSecondaryImage { get; set; }
    }
}