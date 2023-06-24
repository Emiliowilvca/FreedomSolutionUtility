namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IState
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int CountryId { get; set; }
    }
}