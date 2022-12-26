using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IPurchaseRTO
    {
        int Id { get; set; }

        DateTime PurchaseDate { get; set; }

        long InvoiceNum { get; set; }

        string ProviderName { get; set; }

        string OperationTypeName { get; set; }

        string MoneyName { get; set; }

        decimal TotalIva { get; set; }

        decimal TotalExenta { get; set; }

        decimal TotalGravada { get; set; }

        decimal TotalNeto { get; set; }

        decimal TotalRetention { get; set; }

        decimal Exchange { get; set; }

        bool RetentionExport { get; set; }
    }
}