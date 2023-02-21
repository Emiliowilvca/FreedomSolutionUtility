using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class DefaultCustomerRTO : IDefaultCustomerRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int CustomerAccountId { get; set; }

        public int CustomerId { get; set; }

        public int PersonId { get; set; }

        public int MoneyId { get; set; }

        public string CustomerAccountName { get; set; }

        public string CustomerName { get; set; }

        public string PersonName { get; set; }

        public string MoneyName { get; set; }
    }
}