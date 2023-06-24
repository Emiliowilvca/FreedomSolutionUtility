using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ICityRTO : ICity
    {
        string StateName { get; set; }

        string CountryName { get; set; }

        int CountryId { get; set; }
    }
}