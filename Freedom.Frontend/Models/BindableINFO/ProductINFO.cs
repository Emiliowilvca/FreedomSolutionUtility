using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class ProductINFO : BindableBase, IProductRTO, ISelectable
    {
        private int _id;
        private string _code;
        private string _name;
        private bool _payTax;
        private decimal _taxRate;
        private decimal _maxDiscount;
        private bool _alterStock;
        private bool _isService;
        private bool _proCheck;
        private decimal _salePrice;
        private int _moneyId;
        private string _symbol;
        private int _decimalPlaces;
        private int _shopId;
        private decimal _stockQuantity;
        private DateTime _expiration;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public bool PayTax { get => _payTax; set => SetProperty(ref _payTax, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public decimal MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public bool AlterStock { get => _alterStock; set => SetProperty(ref _alterStock, value); }

        public bool IsService { get => _isService; set => SetProperty(ref _isService, value); }

        public bool ProCheck { get => _proCheck; set => SetProperty(ref _proCheck, value); }

        public decimal SalePrice { get => _salePrice; set => SetProperty(ref _salePrice, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string Symbol { get => _symbol; set => SetProperty(ref _symbol, value); }

        public int DecimalPlaces { get => _decimalPlaces; set => SetProperty(ref _decimalPlaces, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public decimal StockQuantity { get => _stockQuantity; set => SetProperty(ref _stockQuantity, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

    }
}