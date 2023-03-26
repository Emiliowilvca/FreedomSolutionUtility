using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class StockBind : BindableBase
    {
        private int _id;
        private int _companyId;
        private int _productId;
        private int _shopId;
        private string _quantity;
        private string _lote;
        private string _manufactory;
        private string _expiration;
        private int _sectorId;
        private string _shelving;
        private string _side;
        private string _column;
        private string _line;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public string Quantity { get => _quantity; set => SetProperty(ref _quantity, value); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public string Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public string Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public int SectorId { get => _sectorId; set => SetProperty(ref _sectorId, value); }

        public string Shelving { get => _shelving; set => SetProperty(ref _shelving, value); }

        public string Side { get => _side; set => SetProperty(ref _side, value); }

        public string Column { get => _column; set => SetProperty(ref _column, value); }

        public string Line { get => _line; set => SetProperty(ref _line, value); }
    }
}