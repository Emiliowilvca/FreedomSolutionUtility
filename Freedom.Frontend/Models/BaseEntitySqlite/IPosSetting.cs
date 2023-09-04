namespace Freedom.Frontend.Models.InterfaceEntitySqlite
{
    public interface IPosSetting
    {
        Guid Id { get; set; }

        bool IsSaleImputQuantity { get; set; }

        bool IsGroupSaleItems { get; set; }

        string InvoicePrinter { get; set; }

        string SaleNotePrinter { get; set; }

        /// <summary>
        /// tipo de plazo para generar cuotas
        /// </summary>
        string TermTypeDefault { get; set; }

        int PosDocumentId { get; set; }

        /// <summary>
        /// formato de impresion para Facturas
        /// </summary>
        int PrintFormatInvoiceId { get; set; }

        /// <summary>
        /// Formato de impresion para Control-Interno
        /// </summary>
        int PrintFormatControlInternoId { get; set; }

        /// <summary>
        /// Formato de impresion para Recibo
        /// </summary>
        int PrintFormatReceiptId { get; set; }
    }
}