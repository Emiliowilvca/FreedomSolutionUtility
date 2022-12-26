namespace Freedom.Utility.Models.RPT
{
    public class SaleDetailRpt
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal GrossPrice { get; set; }

        public decimal NetPrice { get; set; }

        public decimal TaxValue { get; set; }

        public decimal TaxRate { get; set; }

        public decimal DiscountRate { get; set; }

        public decimal DiscountValue { get; set; }
    }
}