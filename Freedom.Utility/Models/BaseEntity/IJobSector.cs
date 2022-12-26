namespace Freedom.Utility.Models.BaseEntity
{
    public interface IJobSector
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }
    }
}