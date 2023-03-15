using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    [Obsolete]
    public class PriceRTO : IPriceRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ProductId { get; set; }

        public int MoneyId { get; set; }

        public short Level { get; set; }

        public decimal ValuePrice { get; set; }
         
        public short QuantityPrice { get; set; }

        public byte TypePrice { get; set; }

        public decimal Exchange { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }
        
    }
}