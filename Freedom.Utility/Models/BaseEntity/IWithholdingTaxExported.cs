namespace Freedom.Utility.Models.BaseEntity
{
    public interface IWithholdingTaxExported
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int PurchaseId { get; set; }

        int WithholdingTaxId { get; set; }
    }
}