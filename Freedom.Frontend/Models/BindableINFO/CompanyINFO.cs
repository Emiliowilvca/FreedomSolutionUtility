using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

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
        public string Address { get; set; }
        public string CompanyOwner { get; set; }
        public string Country { get; set; }
        public string FacebookAdress { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime Registered { get; set; }
        public string State { get; set; }
        public int TrialDay { get; set; }
        public string WhatsappPhoneNumber { get; set; }
    }
}