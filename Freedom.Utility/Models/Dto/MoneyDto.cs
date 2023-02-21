using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class MoneyDto : IEntity, IMoney
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }

        public int DecimalPlaces { get; set; }

        public decimal Exchange { get; set; }

        public string IsoCode { get; set; }

        public bool MoneyBase { get; set; }

        public string Symbol { get; set; }

        public decimal CommisionPercent { get; set; }
       
    }
}