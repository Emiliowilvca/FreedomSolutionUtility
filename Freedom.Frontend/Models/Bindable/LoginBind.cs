using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class LoginBind : BindableBase, ILogin
    {
        private string _endPoint;
        private string _password;
        private string _email;
        private bool _rememberme;

        public string EndPoint { get => _endPoint; set => SetProperty(ref _endPoint, value); }

        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public bool Rememberme { get => _rememberme; set => SetProperty(ref _rememberme, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();

            EndPoint = "";
            Password = "";
            Email = "";
            Rememberme = false;
        }

        public override object Clone()
        {
            LoginBind loginBind = (LoginBind)this.MemberwiseClone();
            return loginBind;
        }
    }
}