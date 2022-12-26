namespace Freedom.Utility.Models.BaseEntity
{
    public interface IWithholdingVouchers
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int VourchersType { get; set; }

        string Code { get; set; }

        string Description { get; set; }
    }
}