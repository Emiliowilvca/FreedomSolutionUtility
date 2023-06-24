using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class ProviderPaymentBind : BindableBase, IProviderPayment, ISelectable
    {
        private int _id;
        private int _companyId;
        private DateTime _datePayment;
        private int _providerId;
        private int _moneyId;
        private Guid _userId;
        private int _shopId;
        private int _operationTypeId;
        private int _boxId;
        private int _employeeId;
        private long _receiptNum;
        private string _remark;
        private decimal _totalPayment;
        private decimal _totalInterest;
        private decimal _exchange;
        private bool _status;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime DatePayment { get => _datePayment; set => SetProperty(ref _datePayment, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public long ReceiptNum { get => _receiptNum; set => SetProperty(ref _receiptNum, value); }

        public string Remark { get => _remark; set => SetProperty(ref _remark, value); }

        public decimal TotalPayment { get => _totalPayment; set => SetProperty(ref _totalPayment, value); }

        public decimal TotalInterest { get => _totalInterest; set => SetProperty(ref _totalInterest, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}