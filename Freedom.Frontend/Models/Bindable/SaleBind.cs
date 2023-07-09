using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class SaleBind : BindableBase, ISaleRTO
    {
        private bool _isExpress;
        private bool _status;
        private DateTime _salesDate;
        private decimal _exchange;
        private decimal _totalCost;
        private decimal _totalDiscount;
        private decimal _totalGross;
        private decimal _totalInvoice;
        private decimal _totalMoneyRef1;
        private decimal _totalMoneyRef2;
        private decimal _totalMoneyRef3;
        private decimal _totalNet;
        private decimal _totalTax;
        private Guid _serialId;
        private Guid _userId;
        private int _boxId;
        private int _companyId;
        private int _customerAccountId;
        private int _customerId;
        private int _decimalPlaces;
        private int _employeeId;
        private int _id;
        private int _moneyId;
        private int _operationTypeId;
        private int _personId;
        private int _shopId;
        private long? _invoice;
        private string _accountName;
        private string _authorizedStaff;
        private string _authorizingOfficer;
        private string _boxName;
        private string _creditLimit;
        private string _customerAccount;
        private string _customerAccountName;
        private string _customerAddress;
        private string _customerName;
        private string _customerPhone;
        private string _customerRuc;
        private string _employeeName;
        private string _moneyName;
        private string _moneyReference1;
        private string _moneyReference2;
        private string _moneyReference3;
        private string _moneySymbol;
        private string _operationTypeName;
        private string _shopName;
        private string _userName;

        public bool IsExpress { get => _isExpress; set => SetProperty(ref _isExpress, value); }
        public bool Status { get => _status; set => SetProperty(ref _status, value); }
        public DateTime SalesDate { get => _salesDate; set => SetProperty(ref _salesDate, value); }
        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }
        public decimal TotalCost { get => _totalCost; set => SetProperty(ref _totalCost, value); }
        public decimal TotalDiscount { get => _totalDiscount; set => SetProperty(ref _totalDiscount, value); }
        public decimal TotalGross { get => _totalGross; set => SetProperty(ref _totalGross, value); }
        public decimal TotalInvoice { get => _totalInvoice; set => SetProperty(ref _totalInvoice, value); }
        public decimal TotalMoneyRef1 { get => _totalMoneyRef1; set => SetProperty(ref _totalMoneyRef1, value); }
        public decimal TotalMoneyRef2 { get => _totalMoneyRef2; set => SetProperty(ref _totalMoneyRef2, value); }
        public decimal TotalMoneyRef3 { get => _totalMoneyRef3; set => SetProperty(ref _totalMoneyRef3, value); }
        public decimal TotalNet { get => _totalNet; set => SetProperty(ref _totalNet, value); }
        public decimal TotalTax { get => _totalTax; set => SetProperty(ref _totalTax, value); }
        public Guid SerialId { get => _serialId; set => SetProperty(ref _serialId, value); }
        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }
        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }
        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
        public int CustomerAccountId { get => _customerAccountId; set => SetProperty(ref _customerAccountId, value); }
        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }
        public int DecimalPlaces { get => _decimalPlaces; set => SetProperty(ref _decimalPlaces, value); }
        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }
        public int Id { get => _id; set => SetProperty(ref _id, value); }
        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }
        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }
        public int PersonId { get => _personId; set => SetProperty(ref _personId, value); }
        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }
        public long? Invoice { get => _invoice; set => SetProperty(ref _invoice, value); }
        public string AccountName { get => _accountName; set => SetProperty(ref _accountName, value); }
        public string AuthorizedStaff { get => _authorizedStaff; set => SetProperty(ref _authorizedStaff, value); }
        public string AuthorizingOfficer { get => _authorizingOfficer; set => SetProperty(ref _authorizingOfficer, value); }
        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }
        public string CreditLimit { get => _creditLimit; set => SetProperty(ref _creditLimit, value); }
        public string CustomerAccount { get => _customerAccount; set => SetProperty(ref _customerAccount, value); }
        public string CustomerAccountName { get => _customerAccountName; set => SetProperty(ref _customerAccountName, value); }
        public string CustomerAddress { get => _customerAddress; set => SetProperty(ref _customerAddress, value); }
        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }
        public string CustomerPhone { get => _customerPhone; set => SetProperty(ref _customerPhone, value); }
        public string CustomerRuc { get => _customerRuc; set => SetProperty(ref _customerRuc, value); }
        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }
        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }
        public string MoneyReference1 { get => _moneyReference1; set => SetProperty(ref _moneyReference1, value); }
        public string MoneyReference2 { get => _moneyReference2; set => SetProperty(ref _moneyReference2, value); }
        public string MoneyReference3 { get => _moneyReference3; set => SetProperty(ref _moneyReference3, value); }
        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }
        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }
        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }
        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }
    }
}