using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    [Obsolete("use product Bind", true)]
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
        private string _codeProvider;
        private string _barcode;
        private string _group;
        private string _subGroup;
        private string _brand;
        private string _measure;
        private decimal _weight;
        private decimal _quantityBox;
        private string _urlPrimaryImage;
        private string _urlSecondaryImage;
        private string _moneyName;

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

        public string CodeProvider { get => _codeProvider; set => SetProperty(ref _codeProvider, value); }

        public string Barcode { get => _barcode; set => SetProperty(ref _barcode, value); }

        public string Group { get => _group; set => SetProperty(ref _group, value); }

        public string SubGroup { get => _subGroup; set => SetProperty(ref _subGroup, value); }

        public string Brand { get => _brand; set => SetProperty(ref _brand, value); }

        public string Measure { get => _measure; set => SetProperty(ref _measure, value); }

        public decimal Weight { get => _weight; set => SetProperty(ref _weight, value); }

        public decimal QuantityBox { get => _quantityBox; set => SetProperty(ref _quantityBox, value); }

        public string UrlPrimaryImage { get => _urlPrimaryImage; set => SetProperty(ref _urlPrimaryImage, value); }

        public string UrlSecondaryImage { get => _urlSecondaryImage; set => SetProperty(ref _urlSecondaryImage, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }
    }
}