using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IBankDeposit
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        Guid UserId { get; set; }

        int OperationTypeId { get; set; }

        int MoneyId { get; set; }

        DateTime TransactionDate { get; set; }

        decimal TotalCash { get; set; }

        decimal TotalCheck { get; set; }

        long DepositNumber { get; set; }

        int BankAccountId { get; set; }

        bool Status { get; set; }

        string Concept { get; set; }
    }
}