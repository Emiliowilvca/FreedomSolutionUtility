namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPaymentType
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }
    }
}