using Freedom.Frontend.Models.BaseEntitySqlite;
using SQLite;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    [Serializable]
    public class LoginHistory : IBase, ILoginHistory
    {
        [PrimaryKey, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime LastDateAccess { get; set; }

        public string EndPoint { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool Rememberme { get; set; }
    }
}