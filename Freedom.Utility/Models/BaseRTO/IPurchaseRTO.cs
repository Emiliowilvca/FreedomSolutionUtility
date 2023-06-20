using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IPurchaseRTO : IPurchase
    {
        string ProviderName { get; set; }

        string ProviderRuc { get; set; }

        string OperationTypeName { get; set; }

        string MoneyName { get; set; }

        /// <summary>
        /// nombre de la moneda ej: PYG
        /// </summary>
        string MoneyISO4217 { get; set; }

        string WithholdingConditionSET { get; set; }

        string ShopName { get; set; }

        string BoxName { get; set; }

        string CarrierName { get; set; }

        bool RetentionExport { get; set; }

        decimal TotalRetention { get; set; }
    }
}