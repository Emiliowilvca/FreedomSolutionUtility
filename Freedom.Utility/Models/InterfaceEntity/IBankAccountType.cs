namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IBankAccountType
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}