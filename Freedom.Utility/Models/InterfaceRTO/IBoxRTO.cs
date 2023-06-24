using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IBoxRTO : IBox
    {
        string ShopName { get; set; }

        string MoneyName { get; set; }
    }
}