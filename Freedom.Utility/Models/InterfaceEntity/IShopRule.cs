namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IShopRule
    {
        int Id { get; set; } // table Id

        int CompanyId { get; set; } //navigator

        int ShopId { get; set; } //navigator

        /// <summary>
        /// PersonDefault for sale and others
        /// </summary>
        int PersonId { get; set; }

        /// <summary>
        /// Default Customer for Sale
        /// </summary>
        int CustomerId { get; set; }

        /// <summary>
        /// Default Customer Account for sale
        /// </summary>
        int CustomerAccountId { get; set; }

        int DecimalInStock { get; set; }

        /// <summary>
        /// Price encript
        /// </summary>
        string EncryptPriceKey { get; set; }

        /// <summary>
        /// Taza de interes mensual
        /// </summary>
        decimal InterestRateMonthly { get; set; }

        /// <summary>
        /// porcentaje de Interés por mora Anual
        /// </summary>
        decimal InterestOnArrears { get; set; }

        bool ForceSaleIfStockIsZero { get; set; }

        /// <summary>
        /// Otorgar decuentos
        /// </summary>
        bool GrantDiscounts { get; set; }

        int MaxItemInSale { get; set; }

        int MaxItemInPayment { get; set; }

        bool ModifyPriceInSales { get; set; }

        int OperTypeCashPurchase { get; set; }

        int OperTypeCashSale { get; set; }

        int OperTypeCreditPurchase { get; set; }

        int OperTypeCreditSale { get; set; }

        int PriceLevelDefault { get; set; }

        decimal MaxDiscountPercent { get; set; }

        /// <summary>
        /// Plazo entre cuotas ex:30/60/90 dias
        /// </summary>
        int InstallmentPeriod { get; set; }
    }
}