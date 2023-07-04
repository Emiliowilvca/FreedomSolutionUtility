using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class ShopRuleDto : IEntity, IShopRule
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ShopId { get; set; }

        public int DecimalInStock { get; set; }

        public string EncryptPriceKey { get; set; }

        public decimal InterestRateMonthly { get; set; }

        public decimal InterestOnArrears { get; set; }

        public bool GrantDiscounts { get; set; }

        public int MaxItemInPayment { get; set; }

        public int OperTypeCashPurchase { get; set; }

        public int OperTypeCreditPurchase { get; set; }

        public int PriceLevelDefault { get; set; }
    }
}