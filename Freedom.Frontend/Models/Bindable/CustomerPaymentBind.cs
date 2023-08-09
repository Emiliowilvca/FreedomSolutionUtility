using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class CustomerPaymentBind : BindableBase, ICustomerPaymentRTO
    {
        private int _id;
        private int _companyId;
        private DateTime _datePayment;
        private int _customerId;
        private int _customerAccountId;
        private int _moneyId;
        private Guid _userId;
        private int _shopId;
        private int _operationTypeId;
        private int _boxId;
        private int _employeeId;
        private long? _receiptNum;
        private string _concept;
        private decimal _payValue;
        private decimal _interest;
        private decimal _exchange;
        private Guid _serialId;
        private bool _status;
        private string _customerName;
        private string _customerRuc;
        private string _moneyName;
        private string _moneySymbol;
        private string _decimalPlaces;
        private string _shopName;
        private string _boxName;
        private string _accountName;
        private string _operationTypeName;
        private string _customerAccount;
        private string _customerAddress;
        private string _customerPhone;
        private string _employeeName;
        private string _userName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime DatePayment { get => _datePayment; set => SetProperty(ref _datePayment, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public int CustomerAccountId { get => _customerAccountId; set => SetProperty(ref _customerAccountId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public long? ReceiptNum { get => _receiptNum; set => SetProperty(ref _receiptNum, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public decimal PayValue { get => _payValue; set => SetProperty(ref _payValue, value); }

        public decimal Interest { get => _interest; set => SetProperty(ref _interest, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public Guid SerialId { get => _serialId; set => SetProperty(ref _serialId, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }

        public string CustomerRuc { get => _customerRuc; set => SetProperty(ref _customerRuc, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string DecimalPlaces { get => _decimalPlaces; set => SetProperty(ref _decimalPlaces, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public string AccountName { get => _accountName; set => SetProperty(ref _accountName, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }

        public string CustomerAccount { get => _customerAccount; set => SetProperty(ref _customerAccount, value); }

        public string CustomerAddress { get => _customerAddress; set => SetProperty(ref _customerAddress, value); }

        public string CustomerPhone { get => _customerPhone; set => SetProperty(ref _customerPhone, value); }

        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }
    }
}