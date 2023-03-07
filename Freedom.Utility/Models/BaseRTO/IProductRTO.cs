namespace Freedom.Utility.Models.BaseRTO
{ 
    public interface IProductRTO
    {
        int Id { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        decimal SalePrice { get; set; }

        decimal CostPrice { get; set; }

        int MoneyId { get; set; }

        decimal Exchange { get; set; }

        int ShopId { get; set; }

        decimal StockQuantity { get; set; }

        bool PayTax { get; set; }

        decimal TaxRate { get; set; }

        decimal MaxDiscount { get; set; }

        bool AlterStock { get; set; }

        bool IsService { get; set; }

        bool ProCheck { get; set; }
    }
}