using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface ISale
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        DateTime SalesDate { get; set; }

        long? Invoice { get; set; }

        int ShopId { get; set; }

        int BoxId { get; set; }

        Guid UserId { get; set; }

        int OperationTypeId { get; set; }

        int MoneyId { get; set; }

        int CustomerId { get; set; }

        int CustomerAccountId { get; set; }

        /// <summary>
        /// Cliente persona
        /// </summary>
        int PersonId { get; set; }

        /// <summary>
        /// encargado de la venta
        /// </summary>
        int EmployeeId { get; set; }

        /// <summary>
        /// sale separate by details count per invoice
        /// </summary>
        Guid SerialId { get; set; }

        decimal Exchange { set; get; }

        /// <summary>
        /// Total Bruto (Precio antes del descuento, y antes del impuesto)
        /// </summary>
        decimal TotalGross { get; set; }

        /// <summary>
        /// Total Costo
        /// </summary>
        decimal TotalCost { get; set; }

        /// <summary>
        /// Total Descuentos
        /// </summary>
        decimal TotalDiscount { get; set; }

        /// <summary>
        /// Total impuesto (suma valor de los impuestos)
        /// </summary>
        decimal TotalTax { get; set; }

        /// <summary>
        /// Suma de (Precio bruto - descuentos) + impuestos
        /// </summary>
        decimal TotalNet { get; set; }

        bool Status { get; set; }
    }
}