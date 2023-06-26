using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CustomerDebtBind : BindableBase, ICustomerDebtRTO
    {
        private int _id;
        private int _companyId;
        private int _accountNum;
        private string _name;
        private int _customerId;
        private string _customerFullName;
        private string _ruc;
        private int _moneyId;
        private string _moneyName;
        private int _shopId;
        private string _shopName;
        private int _employeeId;
        private string _employeeName;
        private decimal _creditLimit;
        private string _customerPhone;
        private string _customerCity;
        private int _operationTypeId;
        private string _lastReceiptGenerate;
        private string _concept;
        private string _paymentDate;
        private bool _chargeInterest;
        private decimal _totalAmountImput;
        private decimal _totalBalance;
        private decimal _totalInterest;
        private int _boxId;
        private Guid _serialId;
        private decimal _exchange;
        private Guid _userId;
        private bool _active;
        private DateTime _startDate;
        private DateTime _endDate;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int AccountNum { get => _accountNum; set => SetProperty(ref _accountNum, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public string CustomerFullName { get => _customerFullName; set => SetProperty(ref _customerFullName, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public Guid SerialId { get => _serialId; set => SetProperty(ref _serialId, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }

        public decimal CreditLimit { get => _creditLimit; set => SetProperty(ref _creditLimit, value); }

        public string CustomerPhone { get => _customerPhone; set => SetProperty(ref _customerPhone, value); }

        public string CustomerCity { get => _customerCity; set => SetProperty(ref _customerCity, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public string LastReceiptGenerate { get => _lastReceiptGenerate; set => SetProperty(ref _lastReceiptGenerate, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public string PaymentDate { get => _paymentDate; set => SetProperty(ref _paymentDate, value); }

        public bool ChargeInterest { get => _chargeInterest; set => SetProperty(ref _chargeInterest, value); }

        public decimal TotalAmountImput { get => _totalAmountImput; set => SetProperty(ref _totalAmountImput, value); }

        public decimal TotalBalance { get => _totalBalance; set => SetProperty(ref _totalBalance, value); }

        public decimal TotalInterest { get => _totalInterest; set => SetProperty(ref _totalInterest, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public bool Active { get => _active; set => SetProperty(ref _active, value); }

        public DateTime StartDate { get => _startDate; set => SetProperty(ref _startDate, value); }

        public DateTime EndDate { get => _endDate; set => SetProperty(ref _endDate, value); }
    }
}