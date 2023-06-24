using Freedom.Frontend.Models.InterfaceEntitySqlite;
using SQLite;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freedom.Frontend.Models.SqliteModels
{
    [Serializable]
    public class LoginStore : IBase, ILoginStore
    {
        [PrimaryKey, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string User { get; set; }

        public string Shop { get; set; }

        public string UserSetting { get; set; }

        public string Company { get; set; }

        public string City { get; set; }

        public string Box { get; set; }

        public string ShopRule { get; set; }

        public string Employee { get; set; }

        public string Money { get; set; }

        public string CustomerAccountDefault { get; set; }

        public string PersonDefault { get; set; }

        public DateTime ExpireToken { get; set; }

        public string Token { get; set; }

        public bool Success { get; set; }

        public bool RememberMe { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}