using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class AlterStockBind : BindableBase, IAlterStock
    {
        private int _id;
        private DateTime _alterDate;
        private string _settingType;
        private int _companyId;
        private decimal _decrease;
        private DateTime _expiration;
        private decimal _increase;
        private string _lote;
        private DateTime _manufactory;
        private string _noteReason;
        private int _operationTypeId;
        private int _productId;
        private int _shopId;
        private Guid _userId;
        private int _sectorId;
        private int _shelving;
        private int _side;
        private int _column;
        private int _line;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public DateTime AlterDate { get => _alterDate; set => SetProperty(ref _alterDate, value); }

        public string SettingType { get => _settingType; set => SetProperty(ref _settingType, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public decimal Decrease { get => _decrease; set => SetProperty(ref _decrease, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public decimal Increase { get => _increase; set => SetProperty(ref _increase, value); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public string NoteReason { get => _noteReason; set => SetProperty(ref _noteReason, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int SectorId { get => _sectorId; set => SetProperty(ref _sectorId, value); }

        public int Shelving { get => _shelving; set => SetProperty(ref _shelving, value); }

        public int Side { get => _side; set => SetProperty(ref _side, value); }

        public int Column { get => _column; set => SetProperty(ref _column, value); }

        public int Line { get => _line; set => SetProperty(ref _line, value); }
    }
}