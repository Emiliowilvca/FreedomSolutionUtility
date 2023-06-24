using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class UserBind : BindableBase, IUser, ISelectable
    {
        private Guid _id;
        private string _fullName;
        private string _document;
        private string _address;
        private int _cityId;
        private int _companyId;
        private bool _isSuperUser;
        private bool _isAvailable;
        private double _latitude;
        private double _longitude;
        private string _userName;
        private string _email;
        private string _phoneNumber;
        private string _password;
        private string _confirmPassword;
        private string _userRole;
        private bool _isSelected;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public string FullName { get => _fullName; set => SetProperty(ref _fullName, value); }

        public string Document { get => _document; set => SetProperty(ref _document, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public bool IsSuperUser { get => _isSuperUser; set => SetProperty(ref _isSuperUser, value); }

        public bool IsAvailable { get => _isAvailable; set => SetProperty(ref _isAvailable, value); }

        public double Latitude { get => _latitude; set => SetProperty(ref _latitude, value); }

        public double Longitude { get => _longitude; set => SetProperty(ref _longitude, value); }

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public string PhoneNumber { get => _phoneNumber; set => SetProperty(ref _phoneNumber, value); }

        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public string ConfirmPassword { get => _confirmPassword; set => SetProperty(ref _confirmPassword, value); }

        public string UserRole { get => _userRole; set => SetProperty(ref _userRole, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}