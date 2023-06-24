using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SaleFeesDto : ISaleFees
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int MoneyId { get; set; }

        public int PromissoryNote { get; set; }

        public decimal Feesvalue { get; set; }

        public decimal Exchange { get; set; }

        public DateTime Expirate { get; set; }

        public bool Status { get; set; }

        public byte NumberFees { get; set; }
    }
}