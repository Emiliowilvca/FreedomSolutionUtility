using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ICustomerDebtDetailRTO : ISaleFees, ISale
    {
        int SaleFeesId { get; set; }

        string ShopName { get; set; }

        string BoxName { get; set; }

        DateTime SaleDate { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        string EmployeeName { get; set; }

        string UserName { get; set; }

        /// <summary>
        /// Interés moratorio del saldo de la cuota
        /// Default interest on the installment balance
        /// </summary>
        decimal InterestOnArrears { get; set; }

        decimal PartialPayment { get; set; }

        decimal BalanceFees { get; set; }

        decimal ImputValue { get; set; }

        decimal DaysLate { get; set; }
    }
}