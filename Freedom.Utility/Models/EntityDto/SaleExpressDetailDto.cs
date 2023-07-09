using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class SaleExpressDetailDto : ISaleDetailJson
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public long SaleDetailId { get; set; }

        public int SaleId { get; set; }

        public int ProductId { get; set; }

        public decimal Quantity { get; set; }

        public decimal CostPrice { get; set; }

        public decimal GrossPrice { get; set; }

        public decimal NetPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal DiscountRate { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxValue { get; set; }
    }
}
