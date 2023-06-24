using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class CarrierBind : BindableBase, ICarrier, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _name;
        private string _person;
        private string _address;
        private string _phone;
        private string _mobile;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Person { get => _person; set => SetProperty(ref _person, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public string Mobile { get => _mobile; set => SetProperty(ref _mobile, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}