using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class RoleBind : BindableBase, IRoles
    {
        private bool _superUser;
        private bool _admin;
        private bool _finance;
        private bool _seller;
        private bool _operator;
        private bool _customer;
        private bool _provider;
        private bool _investor;
        private bool _powerUser;

        public bool SuperUser { get => _superUser; set => SetProperty(ref _superUser, value); }

        public bool Admin { get => _admin; set => SetProperty(ref _admin, value); }

        public bool PowerUser { get => _powerUser; set => SetProperty(ref _powerUser, value); }

        public bool Finance { get => _finance; set => SetProperty(ref _finance, value); }

        public bool Seller { get => _seller; set => SetProperty(ref _seller, value); }

        public bool Operator { get => _operator; set => SetProperty(ref _operator, value); }

        public bool Customer { get => _customer; set => SetProperty(ref _customer, value); }

        public bool Provider { get => _provider; set => SetProperty(ref _provider, value); }

        public bool Investor { get => _investor; set => SetProperty(ref _investor, value); }
    }
}