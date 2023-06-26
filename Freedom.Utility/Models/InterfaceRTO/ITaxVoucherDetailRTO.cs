namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ITaxVoucherDetailRTO
    {
        string Code { get; set; }

        string Description { get; set; }

        decimal Price { get; set; }

        decimal Quantity { get; set; }

        decimal SubTotal { get; }

        decimal TaxRate { get; set; }

        decimal TaxTotal { get; }
    }
}