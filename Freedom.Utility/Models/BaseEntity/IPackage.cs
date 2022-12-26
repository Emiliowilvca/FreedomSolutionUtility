namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPackage
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}