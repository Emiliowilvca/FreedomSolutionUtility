namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ITown
    {
        int Id { get; set; }

        string Name { get; set; }

        int CityId { get; set; }

        int CompanyId { get; set; }
    }
}