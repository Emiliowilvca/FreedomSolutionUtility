using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IBankExtraction
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int BankAccountId { get; set; }

        int BankId { get; set; }

        int OperationTypeId { get; set; }

        bool IsDeferredCheck { get; set; }

        Guid UserId { get; set; }

        DateTime PostedDate { get; set; }

        DateTime PaymentDate { get; set; }

        long CheckNumber { get; set; }

        decimal Amount { get; set; }

        string Payee { get; set; }

        string Concept { get; set; }

        bool Status { get; set; }

    }
}