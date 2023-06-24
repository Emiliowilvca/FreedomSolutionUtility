using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ShopRuleRTO : ShopRuleDto, IShopRuleRTO
    {
        public string CustomerName { get; set; }

        public string OperTypeCashPurchaseName { get; set; }

        public string OperTypeCashSaleName { get; set; }

        public string OperTypeCreditPurchaseName { get; set; }

        public string OperTypeCreditSaleName { get; set; }
    }
}