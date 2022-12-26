using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class UserINFO : BindableBase, IUserRTO, ISelectable
    {
        private bool _isSelected;
        private Guid _id;
        private string _fullName;
        private string _document;
        private string _address;
        private string _cityName;
        private string _phoneNumber;
        private string _email;
        private string _userRole;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public string FullName { get => _fullName; set => SetProperty(ref _fullName, value); }

        public string Document { get => _document; set => SetProperty(ref _document, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }

        public string PhoneNumber { get => _phoneNumber; set => SetProperty(ref _phoneNumber, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public string UserRole { get => _userRole; set => SetProperty(ref _userRole, value); }
    }
}