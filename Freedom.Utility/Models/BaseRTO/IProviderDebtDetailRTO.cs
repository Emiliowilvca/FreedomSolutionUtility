using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProviderDebtDetailRTO : IPurchase
    {
        int PurchaseId { get; set; }

        int PurchaseFeesId { get; set; }

        string ShopName { get; set; }

        string BoxName { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        int EmployeeId { get; set; }

        string EmployeeName { get; set; }

        string UserName { get; set; }

        decimal Feesvalue { get; set; }

        decimal PartialPayment { get; set; }

        decimal BalanceFees { get; set; }

        decimal ImputValue { get; set; }

        DateTime Expirate { get; set; }

        byte NumberFees { get; set; }

        decimal DaysLate { get; set; }
    }
}