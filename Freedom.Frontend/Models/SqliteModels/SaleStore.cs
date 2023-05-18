using Freedom.Frontend.Models.BaseEntitySqlite;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    [Serializable]
    public class SaleStore : IBase
    {
        [PrimaryKey, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime SaleDate { get; set; }

        public string Ruc { get; set; }

        public string CustomerName { get; set; }

        public int BoxId { get; set; }

        public string BoxName { get; set; }

        public int MoneyId { get; set; }

        public bool IsExpress { get; set; }

        public decimal Total { get; set; }

        public string MoneyName { get; set; }

        public string JsonModel { get; set; }

        public string JsonDetails { get; set; }
    }
}