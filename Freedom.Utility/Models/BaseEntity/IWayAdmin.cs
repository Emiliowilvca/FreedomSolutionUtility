namespace Freedom.Utility.Models.BaseEntity
{
    public interface IWayAdmin
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}