namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ITax
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        decimal TaxRate { get; set; }
    }
}