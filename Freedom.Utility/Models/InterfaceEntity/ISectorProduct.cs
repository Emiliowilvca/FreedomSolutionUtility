namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ISectorProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}