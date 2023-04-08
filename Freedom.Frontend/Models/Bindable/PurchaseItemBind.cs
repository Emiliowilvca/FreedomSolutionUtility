using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class PurchaseItemBind : BindableBase
    {
        private Guid _id;
        private int _productId;
        private bool _isPopulate;
        private string _code;
        private string _name;
        private Guid _userId;
        private decimal _costPrice;
        private string _lote;
        private string _manufactory;
        private string _expiration;
        private int _moneyId;
        private decimal _quantity;
        private decimal _taxRate;
        private decimal _taxValue;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public decimal CostPrice { get => _costPrice; set => SetProperty(ref _costPrice, value, Refresh); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public string Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public string Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal Quantity { get => _quantity; set => SetProperty(ref _quantity, value, Refresh); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value, Refresh); }

        public decimal TaxValue
        {
            get
            {
                decimal taxValue = 0;
                if (TaxRate != 0)
                {
                    var taxpercent = (TaxRate / 100) + 1;
                    taxValue = CostPrice - (CostPrice / taxpercent);
                }
                return taxValue;
            }

        }

        public decimal SubTotal => CostPrice * Quantity;

        private void Refresh()
        {
            RaisePropertyChanged(nameof(this.SubTotal));
            RaisePropertyChanged(nameof(this.TaxValue));
        }
    }
}