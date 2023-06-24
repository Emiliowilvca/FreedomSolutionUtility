using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class BoxRTO : BoxDto, IBoxRTO
    {
        public string ShopName { get; set; }

        public string MoneyName { get; set; }
    }
}