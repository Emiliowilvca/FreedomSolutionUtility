using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class PurchaseRTO : IPurchaseRTO
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public long InvoiceNum { get; set; }

        public string ProviderName { get; set; }

        public string OperationTypeName { get; set; }

        public string MoneyName { get; set; }

        public decimal TotalIva { get; set; }

        public decimal TotalExenta { get; set; }

        public decimal TotalGravada { get; set; }

        public decimal TotalNeto { get; set; }

        public decimal TotalRetention { get; set; }

        public decimal Exchange { get; set; }

        public bool RetentionExport { get; set; }
    }
}