using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class SaleInfo : BindableBase, ISaleRTO
    {
        private int _id;
        private int _companyId;
        private DateTime _salesDate;
        private long? _invoice;
        private string _customerName;
        private string _customerRuc;
        private string _personName;
        private string _personRuc;
        private int _shopId;
        private int _boxId;
        private int _moneyId;
        private int _customerId;
        private int _customerAccountId;
        private int _personId;
        private int _employeeId;
        private Guid _serialId;
        private Guid _userId;
        private int _operationTypeId;
        private string _moneyName;
        private string _operationTypeName;
        private string _boxName;
        private string _shopName;
        private decimal _exchange;
        private decimal _totalGross;
        private decimal _totalCost;
        private decimal _totalDiscount;
        private decimal _totalTax;
        private decimal _totalNet;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime SalesDate { get => _salesDate; set => SetProperty(ref _salesDate, value); }

        public long? Invoice { get => _invoice; set => SetProperty(ref _invoice, value); }

        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }

        public string CustomerRuc { get => _customerRuc; set => SetProperty(ref _customerRuc, value); }

        public string PersonName { get => _personName; set => SetProperty(ref _personName, value); }

        public string PersonRuc { get => _personRuc; set => SetProperty(ref _personRuc, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public int CustomerAccountId { get => _customerAccountId; set => SetProperty(ref _customerAccountId, value); }

        public int PersonId { get => _personId; set => SetProperty(ref _personId, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public Guid SerialId { get => _serialId; set => SetProperty(ref _serialId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public decimal TotalGross { get => _totalGross; set => SetProperty(ref _totalGross, value); }

        public decimal TotalCost { get => _totalCost; set => SetProperty(ref _totalCost, value); }

        public decimal TotalDiscount { get => _totalDiscount; set => SetProperty(ref _totalDiscount, value); }

        public decimal TotalTax { get => _totalTax; set => SetProperty(ref _totalTax, value); }

        public decimal TotalNet { get => _totalNet; set => SetProperty(ref _totalNet, value); }
        public bool Status { get; set; }
        public bool IsExpress { get; set; }
    }
}