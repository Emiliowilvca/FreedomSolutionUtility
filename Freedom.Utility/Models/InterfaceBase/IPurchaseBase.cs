using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceBase
{
    public interface IPurchaseBase : IEntity
    {
        int CompanyId { get; set; }

        DateTime PurchaseDate { get; set; }

        long InvoiceNum { get; set; }

        int ProviderId { get; set; }

        int OperationTypeId { get; set; }

        int MoneyId { get; set; }

        Guid UserId { get; set; }

        int ShopId { get; set; }

        int BoxId { get; set; }

        int CarrierId { get; set; }

        /// <summary>
        /// Total Purchase
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        ///  Total Taxes in details
        /// </summary>
        decimal TotalTax { get; set; }

        decimal ImportExpence { get; set; }

        bool ItsImport { get; set; }

        decimal Exchange { get; set; }

        bool Status { get; set; }

        string Note { get; set; }

        string Timbrado { get; set; }
    }
}