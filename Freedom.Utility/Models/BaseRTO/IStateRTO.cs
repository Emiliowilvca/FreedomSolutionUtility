namespace Freedom.Utility.Models.BaseRTO
{
    public interface IStateRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string CountryName { get; set; }

        int CountryId { get; set; } 
    }
}