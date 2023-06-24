using Freedom.Utility.Models.EntityRPT;

namespace Freedom.Utility.Models.EntityPlus
{
    public class PurchasePlus : PurchaseRpt
    {
        public string PurchaseDetailJson { get; set; }

        public string PurchaseInstallmentJson { get; set; }

        public string WithholdingTaxJson { get; set; }

        public string WithholdingTaxExportedJson { get; set; }
    }
}