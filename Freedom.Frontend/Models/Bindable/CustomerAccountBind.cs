using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class CustomerAccountBind : BindableBase, ICustomerAccountRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _accountNum;
        private string _name;
        private int _customerId;
        private int _moneyId;
        private int _shopId;
        private int _employeeId;
        private decimal _creditLimit;
        private bool _active;
        private DateTime _startDate;
        private DateTime _endDate;
        private string _customerFullName;
        private string _ruc;
        private string _moneyName;
        private string _shopName;
        private string _employeeName;
        private string _customerPhone;
        private string _customerCity;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int AccountNum { get => _accountNum; set => SetProperty(ref _accountNum, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public decimal CreditLimit { get => _creditLimit; set => SetProperty(ref _creditLimit, value); }

        public bool Active { get => _active; set => SetProperty(ref _active, value); }

        public DateTime StartDate { get => _startDate; set => SetProperty(ref _startDate, value); }

        public DateTime EndDate { get => _endDate; set => SetProperty(ref _endDate, value); }

        public string CustomerFullName { get => _customerFullName; set => SetProperty(ref _customerFullName, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }

        public string CustomerPhone { get => _customerPhone; set => SetProperty(ref _customerPhone, value); }

        public string CustomerCity { get => _customerCity; set => SetProperty(ref _customerCity, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}