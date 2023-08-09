using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Frontend.Models.Bindable
{
    public class ProductMinBind : BindableBase, IProductMin
    {
        private int _id;
        private string _code;
        private string _name;
        private string _codeProvider;
        private string _barcode;
        private string _measureName;
        private string _groupName;
        private string _subGroupName;
        private string _brandName;
        private decimal _weight;
        private string _moneySymbol;
        private string _moneyName;
        private decimal _maxDiscount;
        private decimal _quantityBox;
        private decimal _costPrice;
        private decimal _taxRate;
        private decimal _salePrice;
        private string _lote;
        private int _moneyId;
        private decimal _stockQuantity;
        private DateTime _manufactory;
        private DateTime _expiration;
        private string _urlPrimaryImage;
        private int _measureId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string CodeProvider { get => _codeProvider; set => SetProperty(ref _codeProvider, value); }

        public string Barcode { get => _barcode; set => SetProperty(ref _barcode, value); }

        public string MeasureName { get => _measureName; set => SetProperty(ref _measureName, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }

        public string SubGroupName { get => _subGroupName; set => SetProperty(ref _subGroupName, value); }

        public string BrandName { get => _brandName; set => SetProperty(ref _brandName, value); }

        public decimal Weight { get => _weight; set => SetProperty(ref _weight, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public decimal MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public decimal QuantityBox { get => _quantityBox; set => SetProperty(ref _quantityBox, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public decimal CostPrice { get => _costPrice; set => SetProperty(ref _costPrice, value); }

        public decimal SalePrice { get => _salePrice; set => SetProperty(ref _salePrice, value); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal StockQuantity { get => _stockQuantity; set => SetProperty(ref _stockQuantity, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public string UrlPrimaryImage { get => _urlPrimaryImage; set => SetProperty(ref _urlPrimaryImage, value); }

        public int MeasureId { get => _measureId; set => SetProperty(ref _measureId, value); }
    }
}