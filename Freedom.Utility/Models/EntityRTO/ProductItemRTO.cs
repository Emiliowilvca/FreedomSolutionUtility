using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    [Obsolete("use product full", true)]
    public class ProductItemRTO : ProductRTO, IProductItemRTO
    {
        public string GroupName { get; set; }

        public string SubGroupName { get; set; }

        public string BrandName { get; set; }
    }
}