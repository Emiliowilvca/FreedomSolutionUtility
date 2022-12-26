using Freedom.Frontend.Models.BaseBindables;
using System;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class PaymentSchedule : IPaymentSchedule
    {
        public int Fee { get; set; }

        public DateTime Expire { get; set; }

        public int DaysLate { get; set; }

        public decimal Amount { get; set; }

        public decimal Interest { get; set; }

        public decimal Balance { get; set; }

        public string Money { get; set; }
    }
}