using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class ShopRuleDto : IEntity, IShopRule
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ShopId { get; set; }

        public int CustomerId { get; set; }

        public int PersonId { get; set; }

        public int CustomerAccountId { get; set; }

        public int DecimalInStock { get; set; }

        public string EncryptPriceKey { get; set; }

        public decimal InterestRateMonthly { get; set; }

        public int InstallmentPeriod { get; set; }

        public decimal InterestOnArrears { get; set; }

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
    }
}