using System.ComponentModel;

namespace Freedom.Utility.Enums
{
    internal class purchaseEnums
    {
    }

    /// <summary>
    /// condicion de compra retencion
    /// </summary>
    public enum PurchaseCondition
    {
        CONTADO,
        CREDITO
    }

    public enum VourchersType
    {
        [Description("IVA CONTRIBUYENTE")]
        IvaContribuyente = 1,

        [Description("IVA NO-CONTRIBUYENTE/ NO-RESIDENTE")]
        IvaNoContribuyente = 2,

        [Description("RENTA CONTRIBUYENTE")]
        RentaContribuyente = 3,

        [Description("RENTA NO-CONTRIBUYENTE")]
        RentaNoContribuyente = 4,

        [Description("RENTA NO-RESIDENTE")]
        RentaNoResidente = 5,
    }

    public enum TaxRateEnum
    {
        [Description("Iva 10%")]
        iva10 = 10,

        [Description("Iva 5%")]
        iva5 = 5,

        [Description("Exento")]
        exenta = 0
    }

    /// <summary>
    /// tipo de transaccion en Retencion de iva
    /// </summary>
    public enum TipoComprobanteRetencion
    {
        [Description("Factura")]
        factura = 1,

        [Description("Auto Factura")]
        autofacturas = 5,

        [Description("Entrada a Espectaculos Publicos")]
        espectaculo = 11,

        [Description("Escritura Publica")]
        escrituraPublica,

        [Description("Otros")]
        otros = 17,

        [Description("Planilla de Pagos")]
        planillaPago = 19,

        [Description("Liquidacion de Salarios")]
        liquidacionSalario = 20
    }

    /// <summary>
    /// Situacion del agente retenedor de impuesto
    /// </summary>
    public enum TaxPayerStatusEnum
    {
        [Description("Contribuyente")]
        CONTRIBUYENTE = 1,

        [Description("No Contribuyente")]
        NO_CONTRIBUYENTE = 2,

        [Description("No Residente")]
        NO_RESIDENTE = 3
    }

    public enum PurchaseRequestTypeEnum
    {
        SearchByProviderId = 0,
        SearchByInvoiceNum = 1,
        SearchByMoneyId = 2,
        SearchByOperationTypeId = 3,
        SearchByBoxId = 4
    }
}