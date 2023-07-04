namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IShopRule
    {
        int Id { get; set; } // table Id

        int CompanyId { get; set; } //navigator

        int ShopId { get; set; } //navigator

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

        /// <summary>
        /// Otorgar decuentos
        /// </summary>
        bool GrantDiscounts { get; set; }

        int MaxItemInPayment { get; set; }

        int OperTypeCashPurchase { get; set; }

        int OperTypeCreditPurchase { get; set; }

        int PriceLevelDefault { get; set; }
    }
}