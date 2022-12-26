using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface ICustomerPayment
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        DateTime DatePayment { get; set; }

        int CustomerId { get; set; }

        int CustomerAccountId { get; set; }

        int MoneyId { get; set; }

        Guid UserId { get; set; }

        int ShopId { get; set; }

        int OperationTypeId { get; set; }

        int BoxId { get; set; }

        int EmployeeId { get; set; }

        long? ReceiptNum { get; set; }

        string Concept { get; set; }

        decimal PayValue { get; set; }

        decimal Interest { get; set; }

        decimal Exchange { get; set; }

        /// <summary>
        /// customer payment Serial 
        /// </summary>
        Guid SerialId { get; set; }

        bool Status { get; set; }
    }
}