﻿using Freedom.Frontend.Models.InterfaceEntitySqlite;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.BindableSqlite
{
    public class PosSettingBind : BindableBase, IPosSetting
    {
        private Guid _id;
        private bool _isSaleImputQuantity;
        private string _invoicePrinter;
        private string _saleNotePrinter;
        private string _termTypeDefault;
        private int _posDocumentId;
        private bool _isGroupSaleItems;
        private int _printFormatInvoiceId;
        private int _printFormatControlInternoId;
        private int _printFormatReceiptId;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public bool IsSaleImputQuantity { get => _isSaleImputQuantity; set => SetProperty(ref _isSaleImputQuantity, value); }

        public bool IsGroupSaleItems { get => _isGroupSaleItems; set => SetProperty(ref _isGroupSaleItems, value); }

        public string InvoicePrinter { get => _invoicePrinter; set => SetProperty(ref _invoicePrinter, value); }

        public string SaleNotePrinter { get => _saleNotePrinter; set => SetProperty(ref _saleNotePrinter, value); }

        /// <summary>
        /// tipo de plazo para generar cuotas
        /// </summary>
        public string TermTypeDefault { get => _termTypeDefault; set => SetProperty(ref _termTypeDefault, value); }

        /// <summary>
        /// Punto de impresion
        /// </summary>
        public int PosDocumentId { get => _posDocumentId; set => SetProperty(ref _posDocumentId, value); }

        /// <summary>
        /// formato de impresion para Facturas
        /// </summary>
        public int PrintFormatInvoiceId { get => _printFormatInvoiceId; set => SetProperty(ref _printFormatInvoiceId, value); }

        /// <summary>
        /// Formato de impresion para ControlInterno
        /// </summary>
        public int PrintFormatControlInternoId { get => _printFormatControlInternoId; set => SetProperty(ref _printFormatControlInternoId, value); }

        /// <summary>
        /// Formato de impresion para Recibo
        /// </summary>
        public int PrintFormatReceiptId { get => _printFormatReceiptId; set => SetProperty(ref _printFormatReceiptId, value); }
    }
}