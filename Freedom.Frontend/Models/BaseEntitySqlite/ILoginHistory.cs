using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Frontend.Models.BaseEntitySqlite
{
    public interface ILoginHistory : ILogin
    {
        Guid Id { get; set; }

        DateTime LastDateAccess { get; set; }
    }
}