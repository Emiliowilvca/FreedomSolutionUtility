using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IBankDepositRTO
    {
        int Id { get; set; }

        DateTime TransactionDate { get; set; }

        long DepositNumber { get; set; }

        string OpInitials { get; set; }

        string MoneySymbol { get; set; }

        string BankAccount { get; set; }

        string Concept { get; set; }

        decimal TotalCash { get; set; }

        decimal TotalCheck { get; set; }

        decimal TotalAmount { get; set; }
    }
}