using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ProviderRTO : ProviderDto, IProviderRTO
    {
        public string CityName { get; set; }

        public string ProviderTypeName { get; set; }

        public string PaymentTypeName { get; set; }
    }
}