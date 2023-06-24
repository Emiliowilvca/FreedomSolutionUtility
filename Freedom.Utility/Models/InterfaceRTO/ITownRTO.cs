using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ITownRTO : ITown
    {
        string CityName { get; set; }

        int StateId { get; set; }

        string StateName { get; set; }

        int CountryId { get; set; }

        string CountryName { get; set; }
    }
}