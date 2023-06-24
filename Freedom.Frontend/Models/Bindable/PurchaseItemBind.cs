using Freedom.Utility;
using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class PurchaseItemBind : BindableBase, IPurchaseDetail
    {
        private Guid _id;
        private int _productId;
        private bool _isPopulate;
        private string _code;
        private string _name;
        private Guid _userId;
        private decimal _price;
        private string _lote;
        private int _moneyId;
        private decimal _quantity;
        private decimal _taxRate;
        private decimal _taxValue;
        private string _urlPrimaryImage;
        private DateTime _manufactory;
        private DateTime _expiration;
        private int _purchaseId;
        private string _manufactoryStr;
        private string _expirationStr;

        public PurchaseItemBind()
        {
            SalePriceCollection = new();
        }

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        long IPurchaseDetail.Id { get; set; }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public decimal Price { get => _price; set => SetProperty(ref _price, value, Refresh); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public string ManufactoryStr
        {
            get => _manufactoryStr;
            set => SetProperty(ref _manufactoryStr, value, () => { Manufactory = _manufactoryStr.ToDatetimeNow(); });
        }

        public string ExpirationStr
        {
            get => _expirationStr;
            set => SetProperty(ref _expirationStr, value, () => { Expiration = _expirationStr.ToDatetimeNow(); });
        }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal Quantity { get => _quantity; set => SetProperty(ref _quantity, value, Refresh); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value, Refresh); }

        public decimal TaxValue
        {
            get
            {
                _taxValue = 0;
                if (TaxRate != 0)
                {
                    var taxpercent = (TaxRate / 100) + 1;
                    _taxValue = Price - (Price / taxpercent);
                }
                return IsPopulate ? _taxValue : 0;
            }
            set => SetProperty(ref _taxValue, value);
        }

        public decimal SubTotal => IsPopulate ? Price * Quantity : 0;

        public string UrlPrimaryImage { get => _urlPrimaryImage; set => SetProperty(ref _urlPrimaryImage, value); }

        public List<SalePriceBind> SalePriceCollection { get; set; }

        private void Refresh()
        {
            RaisePropertyChanged(nameof(this.SubTotal));
            RaisePropertyChanged(nameof(this.TaxValue));
        }
    }
}