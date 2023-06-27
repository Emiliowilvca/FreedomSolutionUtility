using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Frontend.Models.BaseBindableEntity
{
    public class ProductItemBase : BindableBase, IProductItem
    {
        private Guid _rowId;
        private int _productId;
        private bool _isPopulate;
        private string _code;
        private string _description;
        private decimal _maxDiscount;
        private decimal _priceCost;
        private decimal _priceSale;
        private string _lote;
        private int _moneyId;
        private decimal _stockQuantity;
        private decimal _taxRate;
        private decimal _taxValue;
        private decimal _discount;
        private string _urlPrimaryImage;
        private DateTime _manufactory;
        private DateTime _expiration;

        public Guid RowId { get => _rowId; set => SetProperty(ref _rowId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }

        public decimal MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public decimal PriceCost { get => _priceCost; set => SetProperty(ref _priceCost, value); }

        public decimal PriceSale { get => _priceSale; set => SetProperty(ref _priceSale, value); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal StockQuantity { get => _stockQuantity; set => SetProperty(ref _stockQuantity, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public decimal TaxValue { get => _taxValue; set => SetProperty(ref _taxValue, value); }

        public decimal Discount { get => _discount; set => SetProperty(ref _discount, value); }

        public string UrlPrimaryImage { get => _urlPrimaryImage; set => SetProperty(ref _urlPrimaryImage, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }
    }
}