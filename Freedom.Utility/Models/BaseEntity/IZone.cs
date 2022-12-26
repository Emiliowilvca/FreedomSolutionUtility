namespace Freedom.Utility.Models.BaseEntity
{
    public interface IZone
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}