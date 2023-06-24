namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IPaymentType
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }
    }
}