using System;

namespace Freedom.Frontend.Models.BaseEntitySqlite
{
    public interface IApiUrlBase
    {
        Guid Id { get; set; }

        string EndPoint { get; set; }

        string EndPointAccount { get; set; }
    }
}