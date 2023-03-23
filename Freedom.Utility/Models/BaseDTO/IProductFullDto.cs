using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseDTO
{
    public interface IProductFullDto : IProduct
    {
        string SubGroupName { get; set; }

        string MeasureName { get; set; }

        string PackageName { get; set; }

        string PriorityName { get; set; }

        string SourceName { get; set; }

        string BrandName { get; set; }

        string GroupName { get; set; }

        int ShopId { get; set; }

        decimal Quantity { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        int SectorId { get; set; }

        int Shelving { get; set; }

        int Side { get; set; }

        int Column { get; set; }

        int Line { get; set; }

        int MoneyId { get; set; }

        decimal CostPrice { get; set; }

        decimal SalePrice { get; set; }

        int PriceLevel { get; set; }

        int QuantityPrice { get; set; }
    }
}