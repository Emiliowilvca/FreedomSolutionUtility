using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ISaleSettingRTO : ISaleSetting
    {
        string AccountName { get; set; }

        int AccountNum { get; set; }

        decimal CreditLimit { get; set; }

        string CustomerAddress { get; set; }

        string CustomerName { get; set; }

        string CustomerPhone { get; set; }

        string CustomerRuc { get; set; }

        int DecimalPlaces { get; set; }

        decimal Exchange { get; set; }

        string IsoCode { get; set; }

        string MoneyName { get; set; }

        string PersonAddress { get; set; }

        string PersonCardId { get; set; }

        string PersonEmail { get; set; }

        string PersonName { get; set; }

        string PersonPhone { get; set; }

        string Symbol { get; set; }
    }
}