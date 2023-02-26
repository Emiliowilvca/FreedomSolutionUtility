namespace Freedom.Utility.Models.BaseRTO
{
    public interface ITownRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        int CityId { get; set; }

        string CityName { get; set; }

        int StateId { get; set; }

        string StateName { get; set; }

        int CountryId { get; set; }

        string CountryName { get; set; }
    }
}