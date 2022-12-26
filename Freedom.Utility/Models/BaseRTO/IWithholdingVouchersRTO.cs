namespace Freedom.Utility.Models.BaseRTO
{
    public interface IWithholdingVouchersRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int VourchersType { get; set; }

        string Code { get; set; }

        string Description { get; set; }
    }
}