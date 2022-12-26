using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class MoneyRTO : IMoneyRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DecimalPlaces { get; set; }

        public decimal Exchange { get; set; }

        public string IsoCode { get; set; }

        public string Symbol { get; set; }

        public int CompanyId { get; set; }

        public bool MoneyBase { get; set; }

        public decimal CommisionPercent { get; set; }

        public int DefaultCustomerAccountId { get; set; }

        public int DefaultCustomerId { get; set; }

        public int DefaultPersonId { get; set; }

        public PersonRTO PersonRTO { get; set; }

        public CustomerAccountRTO CustomerAccountRTO { get; set; }
    }
}