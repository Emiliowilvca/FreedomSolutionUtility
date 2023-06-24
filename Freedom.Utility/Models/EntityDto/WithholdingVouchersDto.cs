using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class WithholdingVouchersDto : IEntity, IWithholdingVouchers
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int TaxPayerStatusId { get; set; }

        public string TaxType { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}