using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IPurchaseProductRTO : IProductMin
    {
        int Quantity { get; set; }
    }
}