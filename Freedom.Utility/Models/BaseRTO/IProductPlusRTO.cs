namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProductPlusRTO : IProductFullRTO
    {
        string StockJson { get; set; }

        string PriceJson { get; set; }
    
    }
}