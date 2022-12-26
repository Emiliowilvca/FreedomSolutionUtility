namespace Freedom.Utility.Models.BaseRTO
{
    public interface ICityRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string StateName { get; set; }

        string CountryName { get; set; }

        int CountryId { get; set; }

        int StateId { get; set; }
    }
}