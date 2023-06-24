namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IJobSector
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }
    }
}