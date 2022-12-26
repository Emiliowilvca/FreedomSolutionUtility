using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class CustomerDebtDetailRTO : ICustomerDebtDetailRTO
    {
        public int SaleId { get; set; }

        public int SaleFeesId { get; set; }

        public long? Invoice { get; set; }

        public int ShopId { get; set; }

        public string ShopName { get; set; }

        public int BoxId { get; set; }

        public string BoxName { get; set; }

        public decimal Exchange { get; set; }

        public DateTime SaleDate { get; set; }

        public int MoneyId { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string UserName { get; set; }

        public decimal TotalTax { get; set; }

        public decimal TotalNet { get; set; }

        public decimal TotalGross { get; set; }

        public decimal TotalDiscount { get; set; }

        public int PromissoryNote { get; set; }

        public decimal Feesvalue { get; set; }

        public decimal InterestOnArrears { get; set; }

        public decimal PartialPayment { get; set; }

        public decimal BalanceFees { get; set; }

        public DateTime Expirate { get; set; }

        public byte NumberFees { get; set; }

        public decimal DaysLate { get; set; }

        public decimal ImputValue { get; set; }
    }
}