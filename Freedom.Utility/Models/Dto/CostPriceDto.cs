using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class CostPriceDto : ICostPrice
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ProductId { get; set; }

        public int MoneyId { get; set; }

        public decimal CostValue { get; set; }
    }
}