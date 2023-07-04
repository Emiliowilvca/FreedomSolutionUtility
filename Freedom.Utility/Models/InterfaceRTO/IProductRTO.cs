using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IProductRTO : IProduct
    {
        string PackageName { get; set; }

        string PriorityName { get; set; }

        string SourceName { get; set; }

        decimal CostPrice { get; set; }

        decimal SalePrice { get; set; }

        int PriceLevel { get; set; }

        int QuantityPrice { get; set; }

        int DecimalPlaces { get; set; }

        string UrlSecondaryImage { get; set; }

        int ShopId { get; set; }

        int SectorId { get; set; }

        int StockId { get; set; }

        int CostPriceId { get; set; }       

        int Shelving { get; set; }

        int Side { get; set; }

        int Column { get; set; }

        int Line { get; set; }

        int MoneyId { get; set; }

        DateTime Expiration { get; set; }

        decimal StockQuantity { get; set; }

        string BrandName { get; set; }

        string GroupName { get; set; }

          string SubGroupName { get; set; }

        public string MeasureName { get; set; }

        string MoneySymbol { get; set; }

        string MoneyName { get; set; }

        string UrlPrimaryImage { get; set; }
         
          string Lote { get; set; }

          DateTime Manufactory { get; set; }
    }
}