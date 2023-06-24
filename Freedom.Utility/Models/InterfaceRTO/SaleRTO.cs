using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ISaleRTO : ISale
    {
        string CustomerName { get; set; }

        string CustomerRuc { get; set; }

        string PersonName { get; set; }

        string PersonRuc { get; set; }

        string MoneyName { get; set; }

        string OperationTypeName { get; set; }

        string BoxName { get; set; }

        string ShopName { get; set; }
    }
}