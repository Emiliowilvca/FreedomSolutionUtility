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

        /// <summary>
        /// Total Purchase
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        ///  Total Taxes in details
        /// </summary>
        decimal TotalTax { get; set; }

        decimal TotalRetention { get; set; }

        decimal Exchange { get; set; }

        bool RetentionExport { get; set; }
    }
}