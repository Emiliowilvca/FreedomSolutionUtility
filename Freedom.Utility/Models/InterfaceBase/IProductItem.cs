namespace Freedom.Utility.Models.InterfaceBase
{
    public interface IProductItem
    {
        int Id { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        decimal MaxDiscount { get; set; }

        decimal QuantityBox { get; set; }

        decimal TaxRate { get; set; }

        decimal CostPrice { get; set; }

        decimal SalePrice { get; set; }

        string Lote { get; set; }

        int MoneyId { get; set; }

        decimal StockQuantity { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        string UrlPrimaryImage { get; set; }
    }
}