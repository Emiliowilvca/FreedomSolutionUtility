using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class SalePriceRTO : SalePriceDto, ISalePriceRTO
    {
        public string MoneySymbol { get; set; }

        public string MoneyName { get; set; }
    }
}