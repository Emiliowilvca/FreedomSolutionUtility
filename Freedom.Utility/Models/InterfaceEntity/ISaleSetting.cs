namespace Freedom.Utility.Models.InterfaceEntity
{
    /// <summary>
    /// Default setting on Sale Initialize form
    /// </summary>
    public interface ISaleSetting : IEntity
    {
        int CompanyId { get; set; }

        int MoneyId { get; set; }

        int ShopId { get; set; }

        /// <summary>
        /// Person Default for sale and others
        /// </summary>
        int PersonId { get; set; }

        /// <summary>
        /// Default Customer for Sale
        /// </summary>
        int CustomerId { get; set; }

        /// <summary>
        /// Default Customer Account for sale and money
        /// </summary>
        int CustomerAccountId { get; set; }

        int OperTypeCashSale { get; set; }

        int OperTypeCreditSale { get; set; }

        int MaxItemInSale { get; set; }

        decimal MaxDiscountPercent { get; set; }

        /// <summary>
        /// Plazo entre cuotas ex:30/60/90 dias
        /// </summary>
        int InstallmentPeriod { get; set; }

        bool ModifyPriceInSales { get; set; }

        bool ForceSaleIfStockIsZero { get; set; }
    }
}