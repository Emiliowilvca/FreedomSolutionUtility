using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class BankDepositRTO : IBankDepositRTO
    {
        public int Id { get; set; }

        public DateTime TransactionDate { get; set; }

        public long DepositNumber { get; set; }

        public string OpInitials { get; set; }

        public string MoneySymbol { get; set; }

        public string BankAccount { get; set; }

        public string Concept { get; set; }

        public decimal TotalCash { get; set; }

        public decimal TotalCheck { get; set; }

        public decimal TotalAmount { get; set; }
    }
}