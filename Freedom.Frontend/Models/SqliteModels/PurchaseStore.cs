using Freedom.Frontend.Models.InterfaceEntitySqlite;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    [Serializable]
    public class PurchaseStore : IBase
    {
        [PrimaryKey]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string Ruc { get; set; }

        public string ProviderName { get; set; }

        public int BoxId { get; set; }

        public string BoxName { get; set; }

        public int MoneyId { get; set; }

        public decimal Total { get; set; }

        public string MoneyName { get; set; }

        public string JsonModel { get; set; }

        public string JsonDetails { get; set; }
    }
}