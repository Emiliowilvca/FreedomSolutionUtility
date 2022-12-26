using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface ISaleFees
    {
        int Id { get; set; }

        int SaleId { get; set; }

        int CustomerId { get; set; }

        int CustomerAccountId { get; set; }

        int MoneyId { get; set; }

        /// <summary>
        /// Nro de Pagare
        /// </summary>
        int PromissoryNote { get; set; }

        /// <summary>
        /// Numero de Cuotas
        /// </summary>
        byte NumberFees { get; set; }

        /// <summary>
        /// Valor de la Cuota
        /// </summary>
        decimal Feesvalue { get; set; }

        decimal Exchange { get; set; }

        /// <summary>
        /// Fecha de vencimiento
        /// </summary>
        DateTime Expirate { get; set; }

        bool Status { get; set; }
    }
}