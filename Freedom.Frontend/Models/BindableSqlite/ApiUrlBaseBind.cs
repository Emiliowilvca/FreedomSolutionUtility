using Freedom.Frontend.Models.BaseEntitySqlite;
using Freedom.Utility.Bindable;
using System;

namespace Freedom.Frontend.Models.BindableSqlite
{
    [Serializable]
    public class ApiUrlBaseBind : BindableBase, IApiUrlBase
    {
        private string _endPoint;
        private string _endPointAccount;
        private Guid _id;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public string EndPoint { get => _endPoint; set => SetProperty(ref _endPoint, value); }

        public string EndPointAccount { get => _endPointAccount; set => SetProperty(ref _endPointAccount, value); }
    }
}