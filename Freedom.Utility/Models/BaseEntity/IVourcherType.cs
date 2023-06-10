namespace Freedom.Utility.Models.BaseEntity
{
    public interface IVourcherType : IEntity
    {
        int CompanyId { get; set; }

        string Name { get; set; }

        string NameSET { get; set; }

        string CodeSET { get; set; }
    }
}