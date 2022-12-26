namespace Freedom.Utility.Models.BaseRTO
{
    public interface IWithholdingTaxExportedRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int PurchaseId { get; set; }

        int WithholdingTaxId { get; set; }
    }
}