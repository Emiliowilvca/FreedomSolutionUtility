using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class ProviderBind : BindableBase, IProvider, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _name;
        private string _address;
        private string _contact;
        private string _phone;
        private string _email;
        private string _ruc;
        private int _providerTypeID;
        private int _cityId;
        private int _paymentTypeId;
        private DateTime _authorization;
        private DateTime _expiration;
        private string _timbrado;
        private string _bankName;
        private string _bankAccountNum;
        private bool _isSelected;
        private string _cityName;
        private string _providerTypeName;
        private string _paymentTypeName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string Contact { get => _contact; set => SetProperty(ref _contact, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public int ProviderTypeID { get => _providerTypeID; set => SetProperty(ref _providerTypeID, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int PaymentTypeId { get => _paymentTypeId; set => SetProperty(ref _paymentTypeId, value); }

        public DateTime Authorization
        {
            get => _authorization;
            set => SetProperty(ref _authorization, value);
        }

        public DateTime Expiration
        {
            get => _expiration;
            set => SetProperty(ref _expiration, value);
        }

        public string Timbrado { get => _timbrado; set => SetProperty(ref _timbrado, value); }

        public string BankName { get => _bankName; set => SetProperty(ref _bankName, value); }

        public string BankAccountNum { get => _bankAccountNum; set => SetProperty(ref _bankAccountNum, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }

        public string ProviderTypeName { get => _providerTypeName; set => SetProperty(ref _providerTypeName, value); }

        public string PaymentTypeName { get => _paymentTypeName; set => SetProperty(ref _paymentTypeName, value); }
    }
}