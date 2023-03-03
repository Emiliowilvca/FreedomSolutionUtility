using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class ProductPlusRTO : ProductFullRTO, IProductPlusRTO
    {
        public string StockJson { get; set; }

        public string PriceJson { get; set; }

    }
}