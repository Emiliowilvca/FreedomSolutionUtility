namespace Freedom.Utility.Models.BaseRTO
{
    public interface IMoneyRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int DecimalPlaces { get; set; }

        decimal Exchange { get; set; }

        string IsoCode { get; set; }

        bool MoneyBase { get; set; }

        string Symbol { get; set; }

        decimal CommisionPercent { get; set; }

        int DefaultCustomerAccountId { get; set; }

        int DefaultCustomerId { get; set; }

        int DefaultPersonId { get; set; }
    }
}