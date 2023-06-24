using Freedom.Frontend.Models.InterfaceEntitySqlite;
using SQLite;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    [Serializable]
    public class PosSetting : IBase, IPosSetting
    {
        [PrimaryKey, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public bool IsSaleImputQuantity { get; set; }

        public string InvoicePrinter { get; set; }

        public string SaleNotePrinter { get; set; }

        public string TermTypeDefault { get; set; }

        public int PosDocumentId { get; set; }
    }
}