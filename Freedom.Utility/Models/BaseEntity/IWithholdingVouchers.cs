namespace Freedom.Utility.Models.BaseEntity
{
    public interface IWithholdingVouchers
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        /// <summary>
        /// CONTRIBUYENTE, NO-CONTRIBUYENTE, NO-RESIDENTE
        /// </summary>
        int TaxPayerStatusId { get; set; }

        /// <summary>
        /// IVA o Renta
        /// </summary>
        string TaxType { get; set; }

        string Code { get; set; }

        string Description { get; set; }
    }
}