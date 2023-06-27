namespace Freedom.Utility.Models.InterfaceBase
{
    public interface IProductItem
    {
        Guid RowId { get; set; }

        int ProductId { get; set; }

        bool IsPopulate { get; set; }

        string Code { get; set; }

        string Description { get; set; }

        decimal MaxDiscount { get; set; }

        decimal PriceCost { get; set; }

        decimal PriceSale { get; set; }

        string Lote { get; set; }

        int MoneyId { get; set; }

        decimal StockQuantity { get; set; }

        decimal TaxRate { get; set; }

        decimal TaxValue { get; set; }

        decimal Discount { get; set; }

        string UrlPrimaryImage { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }
    }
}