using System;

namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ICustomerPaymentDoc
    {
        int Id { get; set; }

        int CustomerPaymentId { get; set; }

        int MoneyId { get; set; }

        string DocumentNum { get; set; }

        string PaymentType { get; set; }

        string Bank { get; set; }
        
        DateTime DateRelease { get; set; }

        DateTime DateExpiration { get; set; }

        string AccountNum { get; set; }

        decimal Exchange { get; set; }

        string Sender { get; set; }

        decimal DocumentValue { get; set; }
    }
}