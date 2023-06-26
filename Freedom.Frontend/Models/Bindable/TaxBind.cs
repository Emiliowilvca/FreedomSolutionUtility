using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class TaxBind : BindableBase, ITaxRTO, ISelectable
    {
        private int _id;
        private string _name;
        private decimal _taxRate;
        private int _companyId;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}