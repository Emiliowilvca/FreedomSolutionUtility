using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IProductRTO : IProduct
    {
        string GroupName { get; set; }

        string SubGroupName { get; set; }

        string MeasureName { get; set; }

        string PackageName { get; set; }

        string PriorityName { get; set; }

        string SourceName { get; set; }

        string BrandName { get; set; }

        decimal CostPrice { get; set; }

        decimal SalePrice { get; set; }

        int PriceLevel { get; set; }

        int QuantityPrice { get; set; }

        int MoneyId { get; set; }

        string Symbol { get; set; }

        string MoneyName { get; set; }

        int DecimalPlaces { get; set; }

        string UrlPrimaryImage { get; set; }

        string UrlSecondaryImage { get; set; }

        int ShopId { get; set; }

        decimal StockQuantity { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        int SectorId { get; set; }

        int Shelving { get; set; }

        int Side { get; set; }

        int Column { get; set; }

        int Line { get; set; }
    }
}