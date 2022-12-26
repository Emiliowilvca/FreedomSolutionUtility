using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class BoxMoneyRTO : IBoxRTO
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ShopId { get; set; }
        public int MoneyId { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string MoneyName { get; set; }
        public MoneyRTO MoneyRTO { get; set; }
    }
} 