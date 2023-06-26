using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ICustomerPaymentRTO : ICustomerPayment
    {
        string CustomerName { get; set; }

        string CustomerRuc { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        string DecimalPlaces { get; set; }

        string ShopName { get; set; }

        string BoxName { get; set; }

        string AccountName { get; set; }
    }
}