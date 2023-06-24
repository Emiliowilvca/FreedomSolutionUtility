using Freedom.Utility.Models.EntityDto;
using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRPT
{
    public class PurchaseRpt : PurchaseRTO, IPurchaseRTO
    {
        public IEnumerable<PurchaseDetailRTO> PurchaseDetails { get; set; }

        public IEnumerable<PurchaseInstallmentRTO> PurchaseInstallments { get; set; }

        public IEnumerable<PurchaseWithHoldingTaxRTO> PurchaseWithHoldingTaxes { get; set; }

        public IEnumerable<WithholdingTaxExportedDto> WithholdingTaxExporteds { get; set; }
    }
}