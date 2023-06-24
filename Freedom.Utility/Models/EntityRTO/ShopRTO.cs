using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ShopRTO : ShopDto, IShopRTO
    {
        public string CityName { get; set; }
    }
}