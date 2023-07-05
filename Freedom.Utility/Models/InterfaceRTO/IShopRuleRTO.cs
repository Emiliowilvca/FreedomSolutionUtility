using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IShopRuleRTO : IShopRule
    {
        string OperTypeCashPurchaseName { get; set; }

        string OperTypeCreditPurchaseName { get; set; }
    }
}