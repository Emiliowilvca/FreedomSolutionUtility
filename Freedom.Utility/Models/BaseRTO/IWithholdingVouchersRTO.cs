namespace Freedom.Utility.Models.BaseRTO
{
    public interface IWithholdingVouchersRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int VourchersTypeId { get; set; }

        string Code { get; set; }

        string Description { get; set; }
    }
}