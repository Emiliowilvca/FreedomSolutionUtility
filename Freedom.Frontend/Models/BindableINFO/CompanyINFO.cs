using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CompanyINFO : BindableBase, ICompanyRTO, ISelectable
    {
        private int _id;
        private string _name;
        private bool _isSelected;
        private string _email;
        private string _phoneNumber;
        private string _city;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public string PhoneNumber { get => _phoneNumber; set => SetProperty(ref _phoneNumber, value); }

        public string City { get => _city; set => SetProperty(ref _city, value); }
    }
}