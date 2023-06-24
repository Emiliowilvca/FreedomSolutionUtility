using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class AuthorizedStaffINFO : BindableBase, IAuthorizedStaff, ISelectable
    {
        private int _id;
        private string _fullName;
        private string _address;
        private string _cardId;
        private int _companyId;
        private string _email;
        private string _phoneNumber;
        private DateTime _birthDate;
        private DateTime _enrollmentDate;
        private bool _isSelected;
        

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string FullName { get => _fullName; set => SetProperty(ref _fullName, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string CardId { get => _cardId; set => SetProperty(ref _cardId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public string PhoneNumber { get => _phoneNumber; set => SetProperty(ref _phoneNumber, value); }

        public DateTime BirthDate { get => _birthDate; set => SetProperty(ref _birthDate, value); }

        public DateTime EnrollmentDate { get => _enrollmentDate; set => SetProperty(ref _enrollmentDate, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}