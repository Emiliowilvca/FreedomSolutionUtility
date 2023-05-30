using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.RTO;

namespace Freedom.Utility.Models.ModelPlus
{
    public interface IProductFull : IProduct
    {
        /* names */
        string SubGroupName { get; set; }

        string MeasureName { get; set; }

        string PackageName { get; set; }

        string PriorityName { get; set; }

        string SourceName { get; set; }

        string BrandName { get; set; }

        string GroupName { get; set; }

        string SectorName { get; set; }

        int MoneyId { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        /* Images url */
        string UrlPrimaryImage { get; set; }

        string UrlSecondaryImage { get; set; }

        /* STOCK */
        int StockId { get; set; }

        int ShopId { get; set; }

        string ShopName { get; set; }

        decimal StockQuantity { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        int SectorId { get; set; }

        int Shelving { get; set; }

        int Side { get; set; }

        int Column { get; set; }

        int Line { get; set; }

        /*Prices*/

        int CostPriceId { get; set; }

        decimal CostPrice { get; set; }

        int PriceLevel { get; set; }

        decimal SalePrice { get; set; }

        int QuantityPrice { get; set; }

        int Installment { get; set; }

        IEnumerable<SalePriceRTO> Prices { get; set; }

        IEnumerable<StockRTO> Stocks { get; set; }

        IEnumerable<ApplyRTO> Applies { get; set; }

        IEnumerable<WayAdminRTO> WayAdmins { get; set; }

        IEnumerable<DrugRTO> Drugs { get; set; }
    }
}