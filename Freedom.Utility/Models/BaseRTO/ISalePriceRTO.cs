namespace Freedom.Utility.Models.BaseRTO
{
    public interface ISalePriceRTO
    {
        int CompanyId { get; set; }
        int Id { get; set; }
        int Installment { get; set; }
        int Level { get; set; }
        int MoneyId { get; set; }
        string MoneyName { get; set; }
        string MoneySymbol { get; set; }
        int ProductId { get; set; }
        int QuantityPrice { get; set; }
        decimal ValuePrice { get; set; }
    }
}