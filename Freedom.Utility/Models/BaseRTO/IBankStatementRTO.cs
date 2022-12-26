using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IBankStatementRTO
    {
        DateTime PostedDate { get; set; }

        DateTime PaymentDate { get; set; }

        string OpType { get; set; }

        long DockNumber { get; set; }

        int Id { get; set; }

        int CompanyId { get; set; }

        int BankAccountId { get; set; }

        int OperationTypeId { get; set; }

        bool IsDeferredCheck { get; set; }

        decimal Debit { get; set; }

        decimal Credit { get; set; }

        decimal Balance { get; }

        decimal PreviousBalance { get; set; }

        string Concept { get; set; }

        bool Status { get; set; }
    }
}