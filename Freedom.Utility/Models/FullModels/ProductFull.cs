using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.ModelPlus;
using Freedom.Utility.Models.RTO;

namespace Freedom.Utility.Models
{
    public class ProductFull : ProductBase, IProductFull
    {
        public string SubGroupName { get; set; }
        public string MeasureName { get; set; }
        public string PackageName { get; set; }
        public string PriorityName { get; set; }
        public string SourceName { get; set; }
        public string BrandName { get; set; }
        public string GroupName { get; set; }
        public string SectorName { get; set; }
        public int MoneyId { get; set; }
        public string MoneyName { get; set; }
        public string MoneySymbol { get; set; }
        public string UrlPrimaryImage { get; set; }
        public string UrlSecondaryImage { get; set; }
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public decimal StockQuantity { get; set; }
        public string Lote { get; set; }
        public DateTime Manufactory { get; set; }
        public DateTime Expiration { get; set; }
        public int SectorId { get; set; }
        public int Shelving { get; set; }
        public int Side { get; set; }
        public int Column { get; set; }
        public int Line { get; set; }
        public decimal CostPrice { get; set; }
        public int PriceLevel { get; set; }
        public int QuantityPrice { get; set; }
        public int Installment { get; set; }
        public int StockId { get; set; }
        public int CostPriceId { get; set; }
        public int SalePriceId { get; set; }
        public decimal SalePrice { get; set; }
        public IEnumerable<ApplyRTO> Applies { get; set; }
        public IEnumerable<WayAdminRTO> WayAdmins { get; set; }
        public IEnumerable<DrugRTO> Drugs { get; set; }
        public IEnumerable<SalePriceRTO> Prices { get; set; }
        public IEnumerable<StockRTO> Stocks { get; set; }
    }
}