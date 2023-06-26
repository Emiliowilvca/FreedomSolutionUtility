using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class ShopBind : BindableBase, IShopRTO, ISelectable
    {
        private int _id;
        private string _address;
        private string _branchManager;
        private int _cityId;
        private int _companyId;
        private string _mail;
        private string _phone;
        private string _name;
        private bool _isSelected;
        private string _cityName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string BranchManager { get => _branchManager; set => SetProperty(ref _branchManager, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Mail { get => _mail; set => SetProperty(ref _mail, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }
    }
}