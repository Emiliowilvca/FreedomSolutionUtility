using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class WithholdingVouchersDto : IEntity, IWithholdingVouchers
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int VourcherTypeId { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}