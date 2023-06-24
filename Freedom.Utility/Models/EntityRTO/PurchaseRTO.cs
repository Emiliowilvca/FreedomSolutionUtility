using Freedom.Utility.Models.EntityBase;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.EntityRTO
{
    public class PurchaseRTO : PurchaseBase, IPurchaseBase
    {
        public string ProviderName { get; set; }

        public decimal TotalRetention { get; set; }

        public bool RetentionExport { get; set; }

        public string OperationTypeName { get; set; }

        public string MoneyName { get; set; }

        public string ShopName { get; set; }

        public string BoxName { get; set; }

        public string CarrierName { get; set; }

        public string ProviderRuc { get; set; }

        public string MoneyISO4217 { get; set; }

        public string WithholdingConditionSET { get; set; }
    }
}