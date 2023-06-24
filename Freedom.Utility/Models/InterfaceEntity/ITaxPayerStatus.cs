namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ITaxPayerStatus : IEntity
    {
        int CompanyId { get; set; }

        string Name { get; set; }

        string CodeSET { get; set; }

        string NameSET { get; set; }
    }
}