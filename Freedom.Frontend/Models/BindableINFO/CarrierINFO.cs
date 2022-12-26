using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CarrierINFO : BindableBase, ICarrierRTO, ISelectable
    {
        private int _id;
        private string _name;
        private string _person;
        private string _address;
        private string _phone;
        private string _mobile;
        private bool _isSelected;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
        public int Id { get => _id; set => SetProperty(ref _id, value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public string Person { get => _person; set => SetProperty(ref _person, value); }
        public string Address { get => _address; set => SetProperty(ref _address, value); }
        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }
        public string Mobile { get => _mobile; set => SetProperty(ref _mobile, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            IsSelected = false;
            Id = 0;
            Name = "";
            Person = "";
            Address = "";
            Phone = "";
            Mobile = "";
        }
    }
}