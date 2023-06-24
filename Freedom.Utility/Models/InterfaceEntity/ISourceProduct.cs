namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ISourceProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}