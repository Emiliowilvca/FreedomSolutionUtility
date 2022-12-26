using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IBankDepositDetail
    {
          int Id { get; set; }

          int BankDepositId { get; set; }

          decimal Amount { get; set; }

          long CheckNumber { get; set; }

          DateTime CheckDate { get; set; }

          string Sender { get; set; }

          string ConceptCheck { get; set; }

          string BankName { get; set; }
    }
}