using Freedom.Utility.Models.Dto;

namespace Freedom.Utility.Models.FullDto
{
    public class ProviderDtoFull : ProviderDto
    {
        public string CityName { get; set; }

        public string ProviderTypeName { get; set; }

        public string PaymentTypeName { get; set; }
    }
}