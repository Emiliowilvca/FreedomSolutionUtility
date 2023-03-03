using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class TaxBind : BindableBase, ITax
    {
        private int _id;
        private string _name;
        private decimal _taxRate;
        private int _companyId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }
    }
}