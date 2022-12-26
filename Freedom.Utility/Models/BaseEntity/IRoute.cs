namespace Freedom.Utility.Models.BaseEntity
{
    public interface IRoute
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int ZoneId { get; set; }
    }
}