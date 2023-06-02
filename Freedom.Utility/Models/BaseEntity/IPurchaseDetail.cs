namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPurchaseDetail
    {
        long Id { get; set; }

        int PurchaseId { get; set; }

        int ProductId { get; set; }

        decimal Price { get; set; }

        decimal Quantity { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxValue { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }
       
    }
}