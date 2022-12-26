using Freedom.Frontend.Models.BaseEntitySqlite;
using SQLite;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    //[SQLite.Table("Product")]
    [Serializable]
    public class ApiUrlBase : IBase, IApiUrlBase
    {
        //[PrimaryKey, AutoIncrement]
        [PrimaryKey, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string EndPoint { get; set; }

        public string EndPointAccount { get; set; }
    }
}