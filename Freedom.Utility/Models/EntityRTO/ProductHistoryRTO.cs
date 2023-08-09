using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ProductHistoryRTO : IProductHistory
    {
        public int ProductId { get; set; }

        public int PurchaseId { get; set; }

        public long InvoiceNum { get; set; }

        public DateTime DatePurchase { get; set; }

        public int OperationTypeId { get; set; }

        public string OperationTypeInitial { get; set; }

        public string OperationTypeName { get; set; }

        public int ProviderId { get; set; }

        public string ProviderName { get; set; }

        public decimal Quantity { get; set; }

        public decimal QuantityBox { get; set; }

        public decimal Price { get; set; }

        public decimal PriceBox { get; set; }

        public string MoneyName { get; set; }

        public string BoxName { get; set; }

        public string ShopName { get; set; }
    }
}