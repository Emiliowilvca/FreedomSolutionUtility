namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IJobPost
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }
    }
}