using System;

namespace Freedom.Frontend.Models.BaseBindableInterface
{
    public interface IPaymentSchedule
    {
        /// <summary>
        /// Nro Cuota
        /// </summary>
        int Fee { get; set; }

        /// <summary>
        /// Vencimiento de las cuotas
        /// </summary>
        DateTime Expire { get; set; }

        /// <summary>
        /// Dias de atraso
        /// </summary>
        int DaysLate { get; set; }

        decimal Amount { get; set; }

        decimal Interest { get; set; }

        decimal Balance { get; set; }

        string Money { get; set; }
    }
}