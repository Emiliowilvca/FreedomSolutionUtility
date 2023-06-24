namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IGroup
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}