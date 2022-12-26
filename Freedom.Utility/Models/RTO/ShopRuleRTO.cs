using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class ShopRuleRTO : IShopRuleRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ShopId { get; set; }

        public string CustomerName { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int PersonId { get; set; }

        public int DecimalInStock { get; set; }

        public string EncryptPriceKey { get; set; }

        public decimal InterestRateMonthly { get; set; }

        public bool ForceSaleIfStockIsZero { get; set; }

        public bool GrantDiscounts { get; set; }

        public int MaxItemInSale { get; set; }

        public int MaxItemInPayment { get; set; }

        public bool ModifyPriceInSales { get; set; }

        public int OperTypeCashPurchase { get; set; }

        public int OperTypeCashSale { get; set; }

        public int OperTypeCreditPurchase { get; set; }

        public int OperTypeCreditSale { get; set; }

        public int PriceLevelDefault { get; set; }

        public decimal MaxDiscountPercent { get; set; }

        public string OperTypeCashPurchaseName { get; set; }

        public string OperTypeCashSaleName { get; set; }

        public string OperTypeCreditPurchaseName { get; set; }

        public string OperTypeCreditSaleName { get; set; }
    }
}