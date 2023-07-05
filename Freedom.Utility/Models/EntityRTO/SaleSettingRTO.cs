using Freedom.Utility.Models.EntityDto;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    /// <summary>
    /// Sale Default values
    /// </summary>
    public class SaleSettingRTO : SaleSettingDto, ISaleSettingRTO
    {
        public string MoneyName { get; set; }

        public int DecimalPlaces { get; set; }

        public decimal Exchange { get; set; }

        public string IsoCode { get; set; }

        public string Symbol { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerRuc { get; set; }

        public int AccountNum { get; set; }

        public string AccountName { get; set; }

        public decimal CreditLimit { get; set; }

        public string PersonName { get; set; }

        public string PersonAddress { get; set; }

        public string PersonCardId { get; set; }

        public string PersonEmail { get; set; }

        public string PersonPhone { get; set; }

        public string OperTypeCashSaleName { get; set; }

        public string OperTypeCreditSaleName { get; set; }
    }
}