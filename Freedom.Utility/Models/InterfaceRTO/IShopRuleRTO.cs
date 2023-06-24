using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IShopRuleRTO : IShopRule
    {
        string CustomerName { get; set; }

        string OperTypeCashPurchaseName { get; set; }

        string OperTypeCashSaleName { get; set; }

        string OperTypeCreditPurchaseName { get; set; }

        string OperTypeCreditSaleName { get; set; }
    }
}