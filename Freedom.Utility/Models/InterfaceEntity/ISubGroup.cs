namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ISubGroup
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int GroupId { get; set; }
    }
}