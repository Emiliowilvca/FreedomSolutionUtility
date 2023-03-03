using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class PurchaseBind : BindableBase, IPurchase, ISelectable
    {
        private int _id;
        private int _companyId;
        private DateTime _purchaseDate;
        private long _invoiceNum;
        private int _providerId;
        private int _operationTypeId;
        private int _moneyId;
        private Guid _userId;
        private int _shopId;
        private int _boxId;
        private int _carrierId;
        private decimal _importExpence;
        private bool _itsImport;
        private decimal _exchange;
        private bool _status;
        private string _note;
        private string _timbrado;
        private bool _isSelected;
        private decimal _totalTax;
        private decimal _total;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime PurchaseDate { get => _purchaseDate; set => SetProperty(ref _purchaseDate, value); }

        public long InvoiceNum { get => _invoiceNum; set => SetProperty(ref _invoiceNum, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int CarrierId { get => _carrierId; set => SetProperty(ref _carrierId, value); }

        public decimal ImportExpence { get => _importExpence; set => SetProperty(ref _importExpence, value); }

        public bool ItsImport { get => _itsImport; set => SetProperty(ref _itsImport, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public string Note { get => _note; set => SetProperty(ref _note, value); }

        public string Timbrado { get => _timbrado; set => SetProperty(ref _timbrado, value); }

        public decimal Total { get => _total; set => SetProperty(ref _total, value); }

        public decimal TotalTax { get => _totalTax; set => SetProperty(ref _totalTax, value); }
    }
}