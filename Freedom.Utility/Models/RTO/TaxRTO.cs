using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class TaxRTO : ITaxRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal TaxRate { get; set; }
    }
}