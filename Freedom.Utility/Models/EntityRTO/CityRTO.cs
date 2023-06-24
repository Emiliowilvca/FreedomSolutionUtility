using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class CityRTO : CityDto, ICityRTO
    {
        public string StateName { get; set; }

        public string CountryName { get; set; }

        public int CountryId { get; set; }
    }
}