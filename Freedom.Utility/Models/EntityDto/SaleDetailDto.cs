using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SaleDetailDto : ISaleDetail
    {
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