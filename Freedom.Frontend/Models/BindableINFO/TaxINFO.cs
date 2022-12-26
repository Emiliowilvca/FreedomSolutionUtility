using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class TaxINFO : BindableBase, ITaxRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;
        private decimal _taxRate;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }
    }
}