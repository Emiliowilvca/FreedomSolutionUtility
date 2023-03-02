using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class BoxBind : BindableBase, IBox, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _shopId;
        private int _moneyId;
        private string _name;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            ShopId = 0;
            MoneyId = 0;
            Name = "";
            IsSelected = false;
        }

        public override object Clone()
        {
            BoxBind boxBind = (BoxBind)this.MemberwiseClone();
            return boxBind;
        }
    }
}