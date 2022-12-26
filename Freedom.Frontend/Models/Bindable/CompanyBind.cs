using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class CompanyBind : BindableBase, ICompany, ISelectable
    {
        private int _id;
        private string _address;
        private string _city;
        private string _name;
        private string _companyOwner;
        private string _country;
        private string _email;
        private string _facebookAdress;
        private bool _isAvailable;
        private string _phoneNumber;
        private DateTime _registered;
        private string _state;
        private int _trialDay;
        private string _whatsappPhoneNumber;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        
        public string CompanyOwner { get => _companyOwner; set => SetProperty(ref _companyOwner, value); }

        public string Country { get => _country; set => SetProperty(ref _country, value); }
        
        public string State { get => _state; set => SetProperty(ref _state, value); }
        
        public string City { get => _city; set => SetProperty(ref _city, value); }
        
        public string Address { get => _address; set => SetProperty(ref _address, value); }
                
        public string Email { get => _email; set => SetProperty(ref _email, value); }
        
        public string FacebookAdress { get => _facebookAdress; set => SetProperty(ref _facebookAdress, value); }
                
        public string PhoneNumber { get => _phoneNumber; set => SetProperty(ref _phoneNumber, value); }
        
        public string WhatsappPhoneNumber { get => _whatsappPhoneNumber; set => SetProperty(ref _whatsappPhoneNumber, value); }
        
        public bool IsAvailable { get => _isAvailable; set => SetProperty(ref _isAvailable, value); }

        public DateTime Registered { get => _registered; set => SetProperty(ref _registered, value); }
        
        public int TrialDay { get => _trialDay; set => SetProperty(ref _trialDay, value); }
        
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            Address = "";
            City = "";
            Name = "";
            CompanyOwner = "";
            Country = "";
            FacebookAdress = "";
            IsAvailable = false;
            Email = "";
            PhoneNumber = "";
            Registered = DateTime.Now;
            State = "";
            TrialDay = 30;
            WhatsappPhoneNumber = "";
            IsSelected = false;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}