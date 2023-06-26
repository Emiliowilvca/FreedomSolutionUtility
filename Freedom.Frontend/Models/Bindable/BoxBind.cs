using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class BoxBind : BindableBase, IBoxRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _shopId;
        private int _moneyId;
        private string _name;
        private bool _isSelected;
        private string _shopName;
        private string _moneyName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }
    }
}