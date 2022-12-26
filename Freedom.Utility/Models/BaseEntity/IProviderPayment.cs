using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IProviderPayment
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        DateTime DatePayment { get; set; }

        int ProviderId { get; set; }

        int MoneyId { get; set; }

        Guid UserId { get; set; }

        int ShopId { get; set; }

        int OperationTypeId { get; set; }

        int BoxId { get; set; }

        int EmployeeId { get; set; }

        /// <summary>
        /// Numero de Recibo
        /// </summary>
        long ReceiptNum { get; set; }

        /// <summary>
        /// Concepto de pago
        /// </summary>
        string Remark { get; set; }

        decimal TotalPayment { get; set; }

        decimal TotalInterest { get; set; }

        decimal Exchange { get; set; }

        bool Status { get; set; }
    }
}