using Freedom.Utility.Models.EntityRPT;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class PurchaseProductRTO : ProductMin, IPurchaseProductRTO
    {
        public int Quantity { get; set; }
    }
}