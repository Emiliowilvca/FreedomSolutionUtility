using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class SalePriceBind : BindableBase
    {
        private int _id;
        private int _companyId;
        private int _productId;
        private int _moneyId;
        private int _level;
        private string _valuePrice;
        private string _quantityPrice;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int Level { get => _level; set => SetProperty(ref _level, value); }

        public string ValuePrice { get => _valuePrice; set => SetProperty(ref _valuePrice, value); }

        public string QuantityPrice { get => _quantityPrice; set => SetProperty(ref _quantityPrice, value); }
    }
}