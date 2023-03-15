namespace Freedom.Utility.Models.BaseRTO
{
    [Obsolete]
    public interface IPriceRTO
    {
        int CompanyId { get; set; }

        decimal Exchange { get; set; }

        int Id { get; set; }

        short Level { get; set; }

        int MoneyId { get; set; }

        int ProductId { get; set; }

        short QuantityPrice { get; set; }

        byte TypePrice { get; set; }

        decimal ValuePrice { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }
    }
}