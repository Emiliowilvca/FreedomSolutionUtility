using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class PurchaseDetailRTO : PurchaseDetailDto, IPurchaseDetailRTO
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}