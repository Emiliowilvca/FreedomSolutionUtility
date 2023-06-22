using Freedom.Utility.Models.Dto;
using Freedom.Utility.Models.RTO;

namespace Freedom.Utility.Models.RPT
{
    public class PurchaseRpt : PurchaseRTO
    {
        public IEnumerable<PurchaseDetailRTO> PurchaseDetails { get; set; }

        public IEnumerable<PurchaseInstallmentRTO> PurchaseInstallments { get; set; }

        public IEnumerable<PurchaseWithHoldingTaxRTO> PurchaseWithHoldingTaxes { get; set; }

        public IEnumerable<WithholdingTaxExportedDto> WithholdingTaxExporteds { get; set; }
    }
}
