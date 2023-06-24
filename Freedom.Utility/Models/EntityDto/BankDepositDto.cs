using Freedom.Utility.Models.InterfaceEntity;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Models.EntityDto
{
    public class BankDepositDto : IBankDeposit
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public Guid UserId { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal TotalCash { get; set; }

        public decimal TotalCheck { get; set; }

        public long DepositNumber { get; set; }

        public int BankAccountId { get; set; }

        public bool Status { get; set; }

        public string Concept { get; set; }

        public int OperationTypeId { get; set; }

        public int MoneyId { get; set; }

        public List<BankDepositDetailDto> DepositDetails { get; set; }
    }
}