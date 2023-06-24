using System;

namespace Freedom.Frontend.Models.InterfaceEntitySqlite
{
    public interface IDarkTheme
    {
        Guid Id { get; set; }

        bool IsDarkTheme { get; set; }
    }
}