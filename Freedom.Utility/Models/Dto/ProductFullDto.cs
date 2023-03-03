using Freedom.Utility.Models.BaseDTO;

namespace Freedom.Utility.Models.Dto
{
    public class ProductFullDto : ProductDto, IProductFullDto
    {
        public string SubGroupName { get; set; }

        public string MeasureName { get; set; }

        public string PackageName { get; set; }

        public string PriorityName { get; set; }

        public string SourceName { get; set; }

        public string BrandName { get; set; }

        public string GroupName { get; set; }
    }
}