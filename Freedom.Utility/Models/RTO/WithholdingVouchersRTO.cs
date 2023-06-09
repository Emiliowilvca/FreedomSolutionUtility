using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class WithholdingVouchersRTO : IWithholdingVouchersRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int VourchersTypeId { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}