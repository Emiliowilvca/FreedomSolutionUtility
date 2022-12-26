using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class CityRTO : ICityRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StateName { get; set; }

        public string CountryName { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }
    }
}