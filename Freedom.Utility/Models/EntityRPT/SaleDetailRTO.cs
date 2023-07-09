using Freedom.Utility.Models.EntityDto;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityRPT
{
    public class SaleDetailRTO : SaleDetailDto, ISaleDetail
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}