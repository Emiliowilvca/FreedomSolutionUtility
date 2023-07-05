using Freedom.Utility.Models.EntityDto;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ShopRuleRTO : ShopRuleDto, IShopRuleRTO
    {
        public string OperTypeCashPurchaseName { get; set; }

        public string OperTypeCreditPurchaseName { get; set; }


    }
}