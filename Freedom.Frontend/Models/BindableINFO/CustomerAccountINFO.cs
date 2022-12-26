using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CustomerAccountINFO : BindableBase, ICustomerAccountRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _accountNum;
        private string _name;
        private int _customerId;
        private int _moneyId;
        private string _moneyName;
        private int _shopId;
        private string _shopName;
        private int _employeeId;
        private string _employeeName;
        private decimal _creditLimit;
        private string _customerFullName;
        private string _ruc;
        private bool _isSelected;
        private string _customerPhone;
        private string _customerCity;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int AccountNum { get => _accountNum; set => SetProperty(ref _accountNum, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }

        public decimal CreditLimit { get => _creditLimit; set => SetProperty(ref _creditLimit, value); }

        public string CustomerFullName { get => _customerFullName; set => SetProperty(ref _customerFullName, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public string CustomerPhone { get => _customerPhone; set => SetProperty(ref _customerPhone, value); }

        public string CustomerCity { get => _customerCity; set => SetProperty(ref _customerCity, value); }

    }
}