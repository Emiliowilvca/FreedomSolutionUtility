using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    [Obsolete("use product full", true)]
    public class ProductItemRTO : ProductRTO, IProductItemRTO
    {
        public string CodeProvider { get; set; }

        public string Barcode { get; set; }

        public string GroupName { get; set; }

        public string SubGroupName { get; set; }

        public string BrandName { get; set; }

        public string MoneyName { get; set; }

        public decimal QuantityBox { get; set; }

        public decimal Weight { get; set; }
    }
}