using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPurchase
    {
        int Id { get; set; }

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

        decimal TotalIva { get; set; }

        decimal TotalExenta { get; set; }

        decimal TotalGravada { get; set; }

        decimal TotalNeto { get; set; }

        decimal ImportExpence { get; set; }

        bool ItsImport { get; set; }

        decimal Exchange { get; set; }

        bool Status { get; set; }

        string Note { get; set; }

        string Timbrado { get; set; }
    }
}