using Freedom.Frontend.Models.BaseBindables;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class PayOffCalculator : IPayOffCalculator
    {
        public decimal LoanAmount { get; set; }

        public decimal AmountDelivery { get; set; }

        public decimal BalanceOwed { get; set; }

        public int TermType { get; set; }

        public int FeesCount { get; set; }

        public DateTime StartDate { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }

        public string CompanyName { get; set; }

        public string ShopName { get; set; }

        public string ShopAddress { get; set; }

        public string ShopPhone { get; set; }

        public string UserName { get; set; }

        public string BoxName { get; set; }

        public string BusinessName { get; set; }

        public int OperationTypeId { get; set; }

        public string OperationTypeName { get; set; }
    }
}