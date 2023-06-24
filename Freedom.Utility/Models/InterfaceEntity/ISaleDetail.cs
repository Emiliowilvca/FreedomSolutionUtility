namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ISaleDetail
    {
        long SaleDetailId { get; set; }

        int SaleId { get; set; }

        int ProductId { get; set; }

        decimal Quantity { get; set; }

        decimal CostPrice { get; set; }

        decimal GrossPrice { get; set; }

        decimal NetPrice { get; set; }

        decimal Discount { get; set; }

        /// <summary>
        /// Discount Percent
        /// </summary>
        decimal DiscountRate { get; set; }

        /// <summary>
        /// Tax percent
        /// </summary>
        decimal TaxRate { get; set; }

        /// <summary>
        /// Tax Value
        /// </summary>
        decimal TaxValue { get; set; }
    }
}