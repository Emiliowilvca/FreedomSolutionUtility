namespace Freedom.Utility.Models.EntityDto
{
    public class PricesDto
    {
        public CostPriceDto CostPrice { get; set; }

        public IEnumerable<SalePriceDto> SalePrices { get; set; }
    }
}