using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Frontend.Models.InterfaceEntitySqlite
{
    public interface ILoginHistory : ILogin
    {
        Guid Id { get; set; }

        DateTime LastDateAccess { get; set; }
    }
}