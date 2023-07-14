using System;

namespace Freedom.Frontend.Models.InterfaceEntitySqlite
{
    public interface IApiUrlBase
    {
        Guid Id { get; set; }

        string EndPoint { get; set; }

        string EndPointAccount { get; set; }

        string VersionCheckerEndPoint { get; set; }
    }
}