using Freedom.Utility.Models.EntityRTO;
using System;

namespace Freedom.Frontend.Models.InterfaceEntitySqlite
{
    public interface ILoginStore
    {
        Guid Id { get; set; }

        Guid UserId { get; set; }

        string User { get; set; }

        string Shop { get; set; }

        string Box { get; set; }

        string UserSetting { get; set; }

        string Company { get; set; }

        string City { get; set; }

        string ShopRule { get; set; }

        string Employee { get; set; }

        string Money { get; set; }

        DateTime ExpireToken { get; set; }

        string Token { get; set; }

        bool Success { get; set; }

        bool RememberMe { get; set; }

        string Password { get; set; }

        string Email { get; set; }
    }
}