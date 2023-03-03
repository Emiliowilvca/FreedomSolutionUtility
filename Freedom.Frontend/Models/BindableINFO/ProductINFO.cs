using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class ProductINFO : BindableBase, IProductRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _code;
        private string _codeProvider;
        private string _barcode;
        private string _name;
        private string _brandName;
        private int _groupId;
        private int _brandId;
        private string _groupName;
        private decimal _salePrice;
        private decimal _costPrice;
        private decimal _stockQuantity;
        private string _moneySymbol;
        private int _moneyId;
        private decimal _taxRate;
        private bool _payTax;
        private decimal _quantityBox;
        private decimal _maxDiscount;
        private decimal _exchange;
        private int _shopId;
        private bool _alterStock;
        private bool _isService;
        private bool _proCheck;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string CodeProvider { get => _codeProvider; set => SetProperty(ref _codeProvider, value); }

        public string Barcode { get => _barcode; set => SetProperty(ref _barcode, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string BrandName { get => _brandName; set => SetProperty(ref _brandName, value); }

        public int GroupId { get => _groupId; set => SetProperty(ref _groupId, value); }

        public int BrandId { get => _brandId; set => SetProperty(ref _brandId, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }

        public decimal SalePrice { get => _salePrice; set => SetProperty(ref _salePrice, value); }

        public decimal CostPrice { get => _costPrice; set => SetProperty(ref _costPrice, value); }

        public decimal StockQuantity { get => _stockQuantity; set => SetProperty(ref _stockQuantity, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public bool PayTax { get => _payTax; set => SetProperty(ref _payTax, value); }

        public decimal QuantityBox { get => _quantityBox; set => SetProperty(ref _quantityBox, value); }

        public decimal MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public bool AlterStock { get => _alterStock; set => SetProperty(ref _alterStock, value); }

        public bool IsService { get => _isService; set => SetProperty(ref _isService, value); }

        public bool ProCheck { get => _proCheck; set => SetProperty(ref _proCheck, value); }
    }
}