namespace Freedom.Utility.Models.InterfaceBase
{
    public interface IProductHistory
    {
        string BoxName { get; set; }
        DateTime DatePurchase { get; set; }
        long InvoiceNum { get; set; }
        string MoneyName { get; set; }
        int OperationTypeId { get; set; }
        string OperationTypeInitial { get; set; }
        string OperationTypeName { get; set; }
        decimal Price { get; set; }
        decimal PriceBox { get; set; }
        int ProductId { get; set; }
        int ProviderId { get; set; }
        string ProviderName { get; set; }
        int PurchaseId { get; set; }
        decimal Quantity { get; set; }
        decimal QuantityBox { get; set; }
        string ShopName { get; set; }
    }
}