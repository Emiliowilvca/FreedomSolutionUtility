using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IPurchaseDetailRTO : IPurchaseDetail
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}