using System.ComponentModel;

namespace Freedom.Utility.Enums
{
    internal class Financing
    {
    }

    /// <summary>
    /// Plan de Cuotas, Tipos de Pagos
    /// </summary>
    public enum deadlineTypeEnum
    {
        /// <summary>
        /// Cada dia todos los dias
        /// </summary>
        [Description("CADA 1 DIA")]
        everyday = 1,

        /// <summary>
        /// Semanal
        /// </summary>
        [Description("SEMANAL")]
        weekly,

        /// <summary>
        /// quincenal
        /// </summary>
        [Description("QUINCENAL")]
        Fifteen,

        /// <summary>
        /// Mensual
        /// </summary>
        [Description("MENSUAL")]
        monthly,

        /// <summary>
        /// Cada 45 dias
        /// </summary>
        [Description("CADA 45 DIAS")]
        fortyfive,

        /// <summary>
        /// Cada 60 dias
        /// </summary>
        [Description("CADA 60 DIAS")]
        sixty,

        /// <summary>
        /// cada 90 dias
        /// </summary>
        [Description("CADA 90 DIAS")]
        ninety
    };
}