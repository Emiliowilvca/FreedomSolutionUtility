namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IPackage
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}