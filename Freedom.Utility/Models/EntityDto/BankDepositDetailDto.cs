using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    public class BankDepositDetailDto : IBankDepositDetail
    {
        public int Id { get; set; }

        public int BankDepositId { get; set; }

        public decimal Amount { get; set; }

        public long CheckNumber { get; set; }

        public DateTime CheckDate { get; set; }

        public string Sender { get; set; }

        public string ConceptCheck { get; set; }

        public string BankName { get; set; }
    }
}