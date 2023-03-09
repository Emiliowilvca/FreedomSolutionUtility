namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProductRTO
    {
        int Id { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        bool PayTax { get; set; }

        decimal TaxRate { get; set; }

        decimal MaxDiscount { get; set; }

        bool AlterStock { get; set; }

        bool IsService { get; set; }

        bool ProCheck { get; set; }

        //price sale
        decimal SalePrice { get; set; }

        //money

        int MoneyId { get; set; }

        string Symbol { get; set; }

        int DecimalPlaces { get; set; }

        //stock
        int ShopId { get; set; }

        decimal StockQuantity { get; set; }
    }
}