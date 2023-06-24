using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ISalePriceRTO : ISalePrice
    {
        string MoneyName { get; set; }

        string MoneySymbol { get; set; }
    }
}