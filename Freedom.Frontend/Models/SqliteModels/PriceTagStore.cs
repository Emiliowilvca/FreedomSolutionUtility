using Freedom.Frontend.Models.BaseEntitySqlite;
using Freedom.Frontend.Models.InterfaceEntitySqlite;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    [Serializable]
    public class PriceTagStore : IBase, IPriceTagStore
    {
        [PrimaryKey, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public int CompanyId { get; set; }

        public int ShopId { get; set; }

        public Guid UserId { get; set; }

        public DateTime StoreDate { get; set; }

        public string UserName { get; set; }

        public string CompanyName { get; set; }

        public string ShopName { get; set; }

        public string JsonModel { get; set; }
    }
}