using Freedom.Frontend.Models.InterfaceEntitySqlite;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.BindableSqlite
{
    [Serializable]
    public class ApiUrlBaseBind : BindableBase, IApiUrlBase
    {
        private string _endPoint;
        private string _endPointAccount;
        private Guid _id;
        private string _deploymentEndPoint;
        private string _versionCheckerEndPoint;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public string EndPoint { get => _endPoint; set => SetProperty(ref _endPoint, value); }

        public string EndPointAccount { get => _endPointAccount; set => SetProperty(ref _endPointAccount, value); }

        public string DeploymentEndPoint { get => _deploymentEndPoint; set => SetProperty(ref _deploymentEndPoint, value); }

        public string VersionCheckerEndPoint { get => _versionCheckerEndPoint; set => SetProperty(ref _versionCheckerEndPoint, value); }
    }
}