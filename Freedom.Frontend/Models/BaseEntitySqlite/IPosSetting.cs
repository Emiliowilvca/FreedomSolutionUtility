using System;

namespace Freedom.Frontend.Models.BaseEntitySqlite
{
    public interface IPosSetting
    {
        Guid Id { get; set; }

        bool IsSaleImputQuantity { get; set; }

        string InvoicePrinter { get; set; }

        string SaleNotePrinter { get; set; }

        /// <summary>
        /// tipo de plazo para generar cuotas
        /// </summary>
        string TermTypeDefault { get; set; }


          int PosDocumentId { get; set; }
    }
}