namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IWithholdingTaxExported
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int PurchaseId { get; set; }

        int PurchaseWithHoldingTaxId { get; set; }
    }
}