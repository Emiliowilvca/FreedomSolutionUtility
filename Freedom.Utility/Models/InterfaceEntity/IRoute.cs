namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IRoute
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int ZoneId { get; set; }
    }
}