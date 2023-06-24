using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class TownRTO : TownDto, ITownRTO
    {
        public string CityName { get; set; }

        public int StateId { get; set; }

        public string StateName { get; set; }

        public int CountryId { get; set; }

        public string CountryName { get; set; }
    }
}