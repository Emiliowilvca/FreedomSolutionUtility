using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class StockInfo : BindableBase, IStockRTO
    {
        private int _column;
        private int _companyId;
        private DateTime _expiration;
        private int _id;
        private int _line;
        private string _lote;
        private DateTime _manufactory;
        private int _productId;
        private decimal _quantity;
        private int _sectorId;
        private int _shelving;
        private int _shopId;
        private int _side;

        public int Column { get => _column; set => SetProperty(ref _column, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int Line { get => _line; set => SetProperty(ref _line, value); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public decimal Quantity { get => _quantity; set => SetProperty(ref _quantity, value); }

        public int SectorId { get => _sectorId; set => SetProperty(ref _sectorId, value); }

        public int Shelving { get => _shelving; set => SetProperty(ref _shelving, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int Side { get => _side; set => SetProperty(ref _side, value); }
    }
}