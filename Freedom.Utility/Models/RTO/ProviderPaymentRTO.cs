using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class ProviderPaymentRTO : IProviderPaymentRTO
    {
        public int Id { get; set; }

        public DateTime DatePayment { get; set; }

        public string Remark { get; set; }

        public decimal TotalPayment { get; set; }

        public decimal TotalInterest { get; set; }

        public decimal Exchange { get; set; }
    }
}