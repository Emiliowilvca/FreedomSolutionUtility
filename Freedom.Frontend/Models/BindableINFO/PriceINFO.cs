using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class PriceINFO : BindableBase, IPriceRTO, ISelectable
    {
        private int _companyId;
        private decimal _exchange;
        private int _id;
        private short _level;
        private int _moneyId;
        private int _productId;
        private short _quantity;
        private byte _typePrice;
        private decimal _valuePrice;
        private string _moneyName;
        private string _moneySymbol;
        private bool _isSelected;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public short Level { get => _level; set => SetProperty(ref _level, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public short Quantity { get => _quantity; set => SetProperty(ref _quantity, value); }

        public byte TypePrice { get => _typePrice; set => SetProperty(ref _typePrice, value); }

        public decimal ValuePrice { get => _valuePrice; set => SetProperty(ref _valuePrice, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }
    }
}