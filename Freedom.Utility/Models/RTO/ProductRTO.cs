using Freedom.Utility.Models.BaseRTO;
using System.Collections.Generic;

namespace Freedom.Utility.Models.RTO
{
    public class ProductRTO : IProductRTO
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string CodeProvider { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public int GroupId { get; set; }

        public int BrandId { get; set; }

        public string GroupName { get; set; }

        public string BrandName { get; set; }

        public decimal TaxRate { get; set; }

        public bool PayTax { get; set; }

        public decimal SalePrice { get; set; }

        public decimal CostPrice { get; set; }

        public decimal StockQuantity { get; set; }

        public string MoneySymbol { get; set; }

        public int MoneyId { get; set; }

        public decimal MaxDiscount { get; set; }

        public decimal QuantityBox { get; set; }

        public IEnumerable<StockRTO> Stocks { get; set; }

        public IEnumerable<PriceRTO> Prices { get; set; }
    }
}