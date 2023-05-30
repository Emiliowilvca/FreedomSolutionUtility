using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class SalePriceBind : BindableBase, ISalePriceRTO
    {
        private int _companyId;
        private int _productId;
        private int _moneyId;
        private int _level;
        private decimal _valuePrice;
        private int _quantityPrice;
        private int _installment;
        private string _moneySymbol;
        private string _moneyName;
        private decimal _percent;
        private decimal _costPrice = 1m;

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int Level { get => _level; set => SetProperty(ref _level, value); }

        public int QuantityPrice { get => _quantityPrice; set => SetProperty(ref _quantityPrice, value); }

        public int Installment { get => _installment; set => SetProperty(ref _installment, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public decimal CostPrice
        {
            get => _costPrice;
            set
            {
                SetProperty(ref _costPrice, value);
            }
        }

        public decimal Percent
        {
            get => _percent;
            set
            {
                SetProperty(ref _percent, value);
                var util = (_costPrice * (_percent / 100));
                _valuePrice = _costPrice + util;
                RaisePropertyChanged(nameof(ValuePrice));
            }
        }

        public decimal ValuePrice
        {
            get => _valuePrice;
            set
            {
                SetProperty(ref _valuePrice, value);
                _percent = ((_valuePrice * 100) / _costPrice) - 100;
                RaisePropertyChanged(nameof(Percent));
            }
        }

        public void Intialize()
        {
            if (CostPrice <= 0)
            {
                CostPrice = 1M;
            }
            Percent = ((_valuePrice * 100) / _costPrice) - 100;
        }
    }
}