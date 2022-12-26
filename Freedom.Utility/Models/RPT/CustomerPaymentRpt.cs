using Freedom.Utility.Models.BaseEntity;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Models.RPT
{
    public class CustomerPaymentRpt : ICustomerPayment
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime DatePayment { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int MoneyId { get; set; }

        public Guid UserId { get; set; }

        public int ShopId { get; set; }

        public int OperationTypeId { get; set; }

        public int BoxId { get; set; }

        public int EmployeeId { get; set; }

        public long? ReceiptNum { get; set; }

        public string Concept { get; set; }

        public decimal PayValue { get; set; }

        public decimal Interest { get; set; }

        public decimal Exchange { get; set; }

        public Guid SerialId { get; set; }

        public bool Status { get; set; }

        public string CustomerName { get; set; }

        public string CustomerRuc { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }

        public string DecimalPlaces { get; set; }

        public string ShopName { get; set; }

        public string BoxName { get; set; }

        public string AccountName { get; set; }

        public IEnumerable<CustomerPaymentDetailRpt> CustomerPaymentDetails { get; set; }
    }
}