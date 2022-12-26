using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPurchaseWithHoldingTax
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int PurchaseId { get; set; }

        DateTime DateRetention { get; set; }

        /// <summary>
        /// nombre de la moneda ej: PYG
        /// </summary>
        string MoneyISO4217 { get; set; }

        /// <summary>
        /// si es contado o credito
        /// </summary>
        string Condition { get; set; }

        /// <summary>
        /// situacion del contribuyente Ej: Contribuyente, No-Contribuyente, No-Residente
        /// </summary>
        string TaxPayerStatus { get; set; }

        /// <summary>
        /// ej: Factura, Autofactura, Entrada a Espectaculos, Escritura Publica, planilla de Pagos, Salarios
        /// </summary>
        int TipoComprobanteId { get; set; }

        bool IsRetentionIVA { get; set; }

        bool IsRetentionRenta { get; set; }

        string ConceptRetentionRenta { get; set; }

        string ConceptRetentionTaxIva { get; set; }

        /// <summary>
        /// cambio de la moneda
        /// </summary>
        decimal ChangeType { get; set; }

        /* ----- Valores de comprobantes ----- */

        /// <summary>
        /// valor total de la factura
        /// </summary>
        decimal TotalInvoice { get; set; }

        /// <summary>
        /// total al 5 porciento de la factura
        /// </summary>
        decimal TotalIva5 { get; set; }

        /// <summary>
        /// total al 10 porciento de la factura
        /// </summary>
        decimal TotalIva10 { get; set; }

        /// <summary>
        ///  total exenta de la factura
        /// </summary>
        decimal TotalExenta { get; set; }

        /* ----- Liquidacion de Iva ----- */

        /// <summary>
        /// total de impuestos al 5%
        /// </summary>
        decimal TaxIva5 { get; set; }

        /// <summary>
        /// total de impuestos al 10%
        /// </summary>
        decimal TaxIva10 { get; set; }

        /// <summary>
        /// total de impuestos en la factura
        /// </summary>
        decimal TaxTotal { get; set; }

        /* ----- Factor de la Retencion ----- */

        /// <summary>
        /// porcentaje de retencion por iva 5%
        /// </summary>
        decimal RetentionPercentIva5 { get; set; }

        /// <summary>
        /// porcentaje de retencion por iva 10%
        /// </summary>
        decimal RetentionPercentIva10 { get; set; }

        /// <summary>
        /// porcentaje de retencion por renta
        /// </summary>
        decimal RetentionPercentRenta { get; set; }

        /// <summary>
        /// valor de retencion por iva 5%
        /// </summary>
        decimal RetentionIva5 { get; set; }

        /// <summary>
        /// valor de retencion por iva 10%
        /// </summary>
        decimal RetentionIva10 { get; set; }

        /// <summary>
        /// valor de retencion por Renta
        /// </summary>
        decimal RetentionRenta { get; set; }

        /// <summary>
        /// valor de retencion por renta-Cabezas
        /// </summary>
        decimal RetentionCabeza { get; set; }

        /// <summary>
        /// valor de retencion de renta-Toneladas
        /// </summary>
        decimal RetentionTonelada { get; set; }

        /// <summary>
        /// suma de todas las retencion Ej: Ret.Renta + Ret.Cabezas + Ret.Toneladas + Ret.Iva10 + Ret.Iva5
        /// </summary>
        decimal RetentionTotalGeneral { get; set; }
    }
}