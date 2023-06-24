using Freedom.Frontend.Models.InterfaceEntitySqlite;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.BindableSqlite
{
    [Serializable]
    public class LoginHistoryBind : BindableBase, ILoginHistory
    {
        private Guid _id;
        private DateTime _lastDateAccess;
        private string _endPoint;
        private string _password;
        private string _email;
        private bool _rememberme;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }
        public DateTime LastDateAccess { get => _lastDateAccess; set => SetProperty(ref _lastDateAccess, value); }
        public string EndPoint { get => _endPoint; set => SetProperty(ref _endPoint, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }
        public string Email { get => _email; set => SetProperty(ref _email, value); }
        public bool Rememberme { get => _rememberme; set => SetProperty(ref _rememberme, value); }
    }
}