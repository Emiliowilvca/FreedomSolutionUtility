﻿using Freedom.Frontend.Models.InterfaceEntitySqlite;
using SQLite;
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

        public string DeploymentEndPoint { get; set; }

        public string VersionCheckerEndPoint { get; set; }
    }
}