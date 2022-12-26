using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    public class CustomerAccountBind : BindableBase, ICustomerAccount
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

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            AccountNum = 0;
            Name = "";
            CustomerId = 0;
            MoneyId = 0;
            ShopId = 0;
            EmployeeId = 0;
            CreditLimit = 0;
            Active = false;
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
        }
    }
}