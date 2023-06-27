using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ProductRTO : ProductBase, IProductRTO
    {
        public string GroupName { get; set; }

        public string SubGroupName { get; set; }

        public string MeasureName { get; set; }

        public string PackageName { get; set; }

        public string PriorityName { get; set; }

        public string SourceName { get; set; }

        public string BrandName { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SalePrice { get; set; }

        public int PriceLevel { get; set; }

        public int QuantityPrice { get; set; }

        public int MoneyId { get; set; }

        public string Symbol { get; set; }

        public string MoneyName { get; set; }

        public int DecimalPlaces { get; set; }

        public string UrlPrimaryImage { get; set; }

        public string UrlSecondaryImage { get; set; }

        public int ShopId { get; set; }

        public decimal StockQuantity { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }

        public int SectorId { get; set; }

        public int Shelving { get; set; }

        public int Side { get; set; }

        public int Column { get; set; }

        public int Line { get; set; }
    }
}