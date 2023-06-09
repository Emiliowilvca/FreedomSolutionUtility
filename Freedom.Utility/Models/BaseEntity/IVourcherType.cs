namespace Freedom.Utility.Models.BaseEntity
{
    public interface IVourcherType : IEntity
    {
        int CompanyId { get; set; }

        string Name { get; set; }
    }
}