using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface ICustomerDebtDetailRTO
    {
        int SaleId { get; set; }

        int SaleFeesId { get; set; }

        long? Invoice { get; set; }

        int ShopId { get; set; }

        string ShopName { get; set; }

        int BoxId { get; set; }

        string BoxName { get; set; }

        decimal Exchange { get; set; }

        DateTime SaleDate { get; set; }

        int MoneyId { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        int EmployeeId { get; set; }

        string EmployeeName { get; set; }

        string UserName { get; set; }

        decimal TotalTax { get; set; }

        decimal TotalNet { get; set; }

        decimal TotalGross { get; set; }

        decimal TotalDiscount { get; set; }

        int PromissoryNote { get; set; }


        decimal Feesvalue { get; set; }

        /// <summary>
        /// Interés moratorio del saldo de la cuota
        /// Default interest on the installment balance
        /// </summary>
        decimal InterestOnArrears { get; set; }

        decimal PartialPayment { get; set; }

        decimal BalanceFees { get; set; }

        decimal ImputValue { get; set; }


        DateTime Expirate { get; set; }

        byte NumberFees { get; set; }

        decimal DaysLate { get; set; }
    }
}