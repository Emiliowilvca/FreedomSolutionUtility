using System.ComponentModel;

namespace Freedom.Utility.Enums
{
    public enum OperationTypeClass
    {
        /// <summary>
        /// Compra de Productos
        /// </summary>
        [Description("Compras")]
        Purchase = 1,

        /// <summary>
        /// Venta de Productos
        /// </summary>
        [Description("Ventas")]
        Sales = 2,

        /// <summary>
        /// Transferencia Entrada
        /// </summary>
        [Description("Tranferencia Entrada")]
        TransferIn = 3,

        /// <summary>
        /// Cobros a Clientes
        /// </summary>
        [Description("Cobro Cliente")]
        PayCustomer = 4,

        /// <summary>
        /// Pagos a Proveedors
        /// </summary>
        [Description("Pago Proveedor")]
        PayProvider = 5,

        /// <summary>
        /// Devolucion por compra
        /// </summary>
        [Description("Devolucion por Compras")]
        ReturnPurchase = 6,

        /// <summary>
        /// Devolucion por venta
        /// </summary>
        [Description("Devolucion por Venta")]
        ReturnSale = 7,

        /// <summary>
        /// Modificacion de Stock
        /// </summary>
        [Description("Modificacion de Stock")]
        StockModify = 8,

        /// <summary>
        /// Adelanto de clientes
        /// </summary>
        [Description("Adelanto Cliente")]
        AdvanceCustomer = 9,

        /// <summary>
        /// Gastos de la empresa
        /// </summary>
        [Description("Gastos")]
        Expences = 10,

        /// <summary>
        /// Inventario de Productos
        /// </summary>
        [Description("Inventarios")]
        Inventory = 11,

        /// <summary>
        /// Retencion de Mercaderia En Salida
        /// </summary>
        [Description("Retencion Egreso")]
        holbackOut = 12,

        /// <summary>
        /// Retencion de Mercaderia en Entrada
        /// </summary>
        [Description("Retencion Ingreso de Productos")]
        holbackIn = 13,

        /// <summary>
        /// Transferencia Salida
        /// </summary>
        [Description("Tranferencia Salida de Productos")]
        TransferOut = 15,

        /// <summary>
        /// Acredita a su Cuenta  Ej; Averia de Productos, Descuentos especiales, Devolucion en facturas canceladas,
        /// bonificacion
        /// </summary>
        [Description("Nota de Credito a Cliente")]
        CustomerCreditNote = 16,

        /// <summary>
        /// Debito o Carga a su cuenta, Aumenta el valor de la deuda. Ej; Fletes, Interes por mora, re-compra externa de producto
        /// </summary>
        [Description("Nota de Debito a Cliente")]
        CustomerDebitNote = 17,

        /// <summary>
        /// Mov.Haber(derecho) Ej. Deposito Efec o cheque, Recibir Giro, transferencia, Prestamo Banco, Compras con targeta credito
        /// </summary>
        [Description("Credito Bancario")]
        BankCredit = 18,

        /// <summary>
        /// Mov.Debe(isquierdo) Ej. Pago Cheque, extraccion, interes, comisiones,talonario,servicios, otros cargos
        /// Pago de Targeta de Credito
        /// </summary>
        [Description("Debito Bancario")]
        BankDebit = 19,

        /// <summary>
        /// Mov. Haber, Ej: Recibir una Transferencia, aumenta valores en la cuenta
        /// </summary>
        [Description("Transf. Bancaria Credito")]
        WireTransferCredit = 20,

        /// <summary>
        /// Mov.Debe Ej: Pago a Importador, resta de valores en la cuenta
        /// </summary>
        [Description("Transf. Bancaria Debito")]
        WireTransferDebit = 21
    }
}