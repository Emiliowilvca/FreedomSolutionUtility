namespace Freedom.Utility.Models.BaseEntity
{
    public interface IDrug
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}