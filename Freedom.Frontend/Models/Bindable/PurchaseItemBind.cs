using Freedom.Utility;
using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class PurchaseItemBind : BindableBase, IPurchaseDetailRTO
    {
        private long _id;
        private int _purchaseId;
        private int _productId;
        private decimal _price;
        private decimal _quantity;
        private decimal _taxRate;
        private decimal _taxValue;
        private string _lote;
        private DateTime _manufactory;
        private DateTime _expiration;
        private string _code;
        private string _description;
        private string _expirationStr;
        private bool _isPopulate;
        private string _manufactoryStr;
        private int _moneyId;
        private Guid _rowId;
        private string _urlPrimaryImage;
        private Guid _userId;

        public long Id { get => _id; set => SetProperty(ref _id, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public decimal Price { get => _price; set => SetProperty(ref _price, value, Refresh); }

        public decimal Quantity { get => _quantity; set => SetProperty(ref _quantity, value, Refresh); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value, Refresh); }

        public decimal TaxValue
        {
            get
            {
                _taxValue = default;
                if (TaxRate != 0m)
                {
                    decimal num = TaxRate / 100m + 1m;
                    _taxValue = Price - Price / num;
                }

                return IsPopulate ? _taxValue : 0m;
            }
            set
            {
                SetProperty(ref _taxValue, value);
            }
        }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }

        public string ExpirationStr
        {
            get => _expirationStr; set => SetProperty(ref _expirationStr,
                                        value, () => { Expiration = _expirationStr.ToDatetimeNow(); });
        }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public string ManufactoryStr
        {
            get => _manufactoryStr; set => SetProperty(ref _manufactoryStr, value,
            () => { Manufactory = _manufactoryStr.ToDatetimeNow(); });
        }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public Guid RowId { get => _rowId; set => SetProperty(ref _rowId, value); }

        public decimal SubTotal => IsPopulate ? (Price * Quantity) : 0m;

        public string UrlPrimaryImage { get => _urlPrimaryImage; set => SetProperty(ref _urlPrimaryImage, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public List<SalePriceBind> SalePriceCollection { get; set; }

        public PurchaseItemBind()
        {
            SalePriceCollection = new List<SalePriceBind>();
        }

        private void Refresh()
        {
            RaisePropertyChanged("SubTotal");
            RaisePropertyChanged("TaxValue");
        }
    }
}