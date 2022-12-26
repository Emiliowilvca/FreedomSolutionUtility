using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class BankStatementRTO : IBankStatementRTO
    {
        public DateTime PostedDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public string OpType { get; set; }

        public long DockNumber { get; set; }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int BankAccountId { get; set; }

        public int OperationTypeId { get; set; }

        public bool IsDeferredCheck { get; set; }

        public string Concept { get; set; }

        public bool Status { get; set; }

        public decimal Debit { get; set; }

        public decimal Credit { get; set; }

        public decimal Balance { get; }

        public decimal PreviousBalance { get; set; }
    }
}