using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.EntityRPT
{
    public class ProductMin : ProductItem, IProductMin
    {
        public string CodeProvider { get; set; }

        public string Barcode { get; set; }

        public string MeasureName { get; set; }

        public string GroupName { get; set; }

        public string SubGroupName { get; set; }

        public string BrandName { get; set; }

        public decimal Weight { get; set; }

        public string MoneySymbol { get; set; }

        public string MoneyName { get; set; }
    }
}