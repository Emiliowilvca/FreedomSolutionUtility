using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProviderPaymentRTO
    {
        int Id { get; set; }

        DateTime DatePayment { get; set; }

        string Remark { get; set; }

        decimal TotalPayment { get; set; }

        decimal TotalInterest { get; set; }

        decimal Exchange { get; set; }
    }
}