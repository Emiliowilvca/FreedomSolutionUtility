using Freedom.Frontend.Models.BaseBindableInterface;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class SaleCashFinish : ISaleCashFinish
    {
        public decimal CashAmount { get; set; }

        public string CashChange { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }

        public string Remark { get; set; }

        public decimal TotalGross { get; set; }

        public decimal TotalNet { get; set; }

        public decimal TotalTaxed { get; set; }

        public decimal TotalDiscount { get; set; }

        public string CompanyName { get; set; }

        public string ShopName { get; set; }

        public string ShopAddress { get; set; }

        public string ShopPhone { get; set; }

        public string UserName { get; set; }

        public string BoxName { get; set; }

        public string CustomerName { get; set; }
    }
}