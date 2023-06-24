using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IShopRTO : IShop
    {
        string CityName { get; set; }
    }
}