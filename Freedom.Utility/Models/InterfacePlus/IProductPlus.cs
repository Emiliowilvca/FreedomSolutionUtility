using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.InterfacePlus
{
    public interface IProductPlus : IProductRTO
    {
        string GroupJson { get; set; }

        string SubGroupJson { get; set; }

        string MeasureJson { get; set; }

        string PackageJson { get; set; }

        string PriorityJson { get; set; }

        string SourceJson { get; set; }

        string BrandJson { get; set; }

        string SalePricesJson { get; set; }

        string CostPriceJson { get; set; }

        string StockJson { get; set; }

        string ApplyJson { get; set; }

        string DrugJson { get; set; }

        string WayAdminJson { get; set; }

        string ImagesNamesJson { get; set; }
    }
}