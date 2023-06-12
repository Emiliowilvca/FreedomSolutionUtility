using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IPurchaseDetailRTO : IPurchaseDetail
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}