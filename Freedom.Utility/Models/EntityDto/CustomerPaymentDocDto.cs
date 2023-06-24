using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    public class CustomerPaymentDocDto : ICustomerPaymentDoc
    {
        public int Id { get; set; }

        public int CustomerPaymentId { get; set; }

        public int MoneyId { get; set; }

        public string DocumentNum { get; set; }

        public string PaymentType { get; set; }

        public string Bank { get; set; }

        public DateTime DateRelease { get; set; }

        public DateTime DateExpiration { get; set; }

        public string AccountNum { get; set; }

        public decimal Exchange { get; set; }

        public string Sender { get; set; }

        public decimal DocumentValue { get; set; }
    }
}