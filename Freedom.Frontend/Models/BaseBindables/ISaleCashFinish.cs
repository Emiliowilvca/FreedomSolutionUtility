namespace Freedom.Frontend.Models.BaseBindables
{
    public interface ISaleCashFinish
    {
        decimal CashAmount { get; set; }

        string CashChange { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        string Remark { get; set; }

        decimal TotalGross { get; set; }

        decimal TotalNet { get; set; }

        decimal TotalTaxed { get; set; }

        decimal TotalDiscount { get; set; }

        string CompanyName { get; set; }

        string ShopName { get; set; }

        string ShopAddress { get; set; }

        string ShopPhone { get; set; }

        string UserName { get; set; }

        string BoxName { get; set; }

        string CustomerName { get; set; }
    }
}