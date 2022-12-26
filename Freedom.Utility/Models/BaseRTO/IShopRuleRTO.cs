namespace Freedom.Utility.Models.BaseRTO
{
    public interface IShopRuleRTO
    {
        int Id { get; set; } // table Id

        int CompanyId { get; set; }

        int ShopId { get; set; } //navigator

        int CustomerId { get; set; }

        int CustomerAccountId { get; set; }

        int PersonId { get; set; }

        string CustomerName { get; set; }

        int DecimalInStock { get; set; }

        /// <summary>
        /// Price encript
        /// </summary>
        string EncryptPriceKey { get; set; }

        /// <summary>
        /// Taza de interes mensual
        /// </summary>
        decimal InterestRateMonthly { get; set; }

        bool ForceSaleIfStockIsZero { get; set; }

        /// <summary>
        /// Otorgar decuentos
        /// </summary>
        bool GrantDiscounts { get; set; }

        int MaxItemInSale { get; set; }

        int MaxItemInPayment { get; set; }

        bool ModifyPriceInSales { get; set; }

        int OperTypeCashPurchase { get; set; }

        string OperTypeCashPurchaseName { get; set; }

        int OperTypeCashSale { get; set; }

        string OperTypeCashSaleName { get; set; }

        int OperTypeCreditPurchase { get; set; }

        string OperTypeCreditPurchaseName { get; set; }

        int OperTypeCreditSale { get; set; }

        string OperTypeCreditSaleName { get; set; }

        int PriceLevelDefault { get; set; }

        decimal MaxDiscountPercent { get; set; }
    }
}