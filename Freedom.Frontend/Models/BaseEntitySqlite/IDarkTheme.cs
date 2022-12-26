using System;

namespace Freedom.Frontend.Models.BaseEntitySqlite
{
    public interface IDarkTheme
    {
        Guid Id { get; set; }

        bool IsDarkTheme { get; set; }
    }
}