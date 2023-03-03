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
    }
}