namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProductRTO
    {
        int Id { get; set; }

        string Code { get; set; }

        string CodeProvider { get; set; }

        string Barcode { get; set; }

        string Name { get; set; }

        int GroupId { get; set; }

        int BrandId { get; set; }

        string BrandName { get; set; }

        string GroupName { get; set; }

        decimal SalePrice { get; set; }

        decimal CostPrice { get; set; }

        decimal StockQuantity { get; set; }

        string MoneySymbol { get; set; }

        int MoneyId { get; set; }

        decimal TaxRate { get; set; }

        bool PayTax { get; set; }

        decimal MaxDiscount { get; set; }

        decimal QuantityBox { get; set; }
    }
}