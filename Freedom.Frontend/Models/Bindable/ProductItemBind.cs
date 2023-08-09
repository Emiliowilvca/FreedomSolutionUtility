using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class ProductItemBind : BindableBase, IProductItem
    {
        private decimal _stockInput;
        private int _id;
        private string _code;
        private string _name;
        private decimal _maxDiscount;
        private decimal _quantityBox;
        private decimal _taxRate;
        private decimal _costPrice;
        private decimal _salePrice;
        private string _lote;
        private int _moneyId;
        private decimal _stockQuantity;
        private DateTime _manufactory;
        private DateTime _expiration;
        private string _urlPrimaryImage;
        private Guid _rowId;
        private bool _isPopulate;
        private Guid _userId;
        private int _measureId;

        public Guid RowId { get => _rowId; set => SetProperty(ref _rowId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

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

        public decimal StockInput { get => _stockInput; set => SetProperty(ref _stockInput, value); }

        public int MeasureId { get => _measureId; set => SetProperty(ref _measureId, value); }
    }
}