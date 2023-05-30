using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface ISalePriceRTO : ISalePrice
    {
        string MoneyName { get; set; }

        string MoneySymbol { get; set; }
    }
}