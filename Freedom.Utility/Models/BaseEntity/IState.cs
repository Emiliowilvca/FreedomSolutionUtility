namespace Freedom.Utility.Models.BaseEntity
{
    public interface IState
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int CountryId { get; set; }
    }
}