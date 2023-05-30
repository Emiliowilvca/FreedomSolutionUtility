using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class SalePriceDto : ISalePrice
    {
        public int ProductId { get; set; }
        public int Level { get; set; }
        public int MoneyId { get; set; }
        public int CompanyId { get; set; }
        public decimal ValuePrice { get; set; }
        public int QuantityPrice { get; set; }
        public int Installment { get; set; }
    }
}