using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class ShopINFO : BindableBase, IShopRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;
        private string _phone;
        private string _mail;
        private string _address;
        private string _cityName;
        private int _cityId;
        private string _branchManager;
        private int _companyId;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public string Mail { get => _mail; set => SetProperty(ref _mail, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }

        public int cityId { get => _cityId; set => SetProperty(ref _cityId, value); }
        public int CityId { get; set; }
        public string BranchManager { get => _branchManager; set => SetProperty(ref _branchManager, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
    }
}