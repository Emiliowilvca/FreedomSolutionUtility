using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    public class TaxPayerStatusDto : IEntity, ITaxPayerStatus
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }
    }
}