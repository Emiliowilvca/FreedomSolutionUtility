using Freedom.Utility.Models.RPT;

namespace Freedom.Utility.Models.FullDto
{
    public class PurchasePlus : PurchaseRpt
    {
        public string PurchaseDetailJson { get; set; }

        public string PurchaseInstallmentJson { get; set; }

        public string WithholdingTaxJson { get; set; }

        public string WithholdingTaxExportedJson { get; set; }
    }
}