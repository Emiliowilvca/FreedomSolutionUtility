using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class SalePriceRTO : ISalePriceRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ProductId { get; set; }

        public int MoneyId { get; set; }

        public int Level { get; set; }

        public decimal ValuePrice { get; set; }

        public int QuantityPrice { get; set; }

        public int Installment { get; set; }

        public string MoneySymbol { get; set; }

        public string MoneyName { get; set; }
    }
}