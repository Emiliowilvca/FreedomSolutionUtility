namespace Freedom.Utility.Models.BaseEntity
{
    public interface IWithholdingVouchers
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int VourcherTypeId { get; set; }

        string Code { get; set; }

        string Description { get; set; }
    }
}
