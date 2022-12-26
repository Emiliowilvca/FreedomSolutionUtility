using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    public class BankExtractionDto : IBankExtraction
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int BankAccountId { get; set; }

        public int BankId { get; set; }

        public int OperationTypeId { get; set; }

        public bool IsDeferredCheck { get; set; }

        public Guid UserId { get; set; }

        public DateTime PostedDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public long CheckNumber { get; set; }

        public decimal Amount { get; set; }

        public string Payee { get; set; }

        public string Concept { get; set; }

        public bool Status { get; set; }
    }
}