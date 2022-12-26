namespace Freedom.Utility.Models.BaseEntity
{
    public interface IProviderType
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }
    }
}