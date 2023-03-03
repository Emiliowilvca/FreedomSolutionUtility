using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class SaleBind : BindableBase
    {
        private string _customerAccountName;
        private string _creditLimit;
        private string _customerName;
        private string _customerRUC;
        private string _moneyReference1;
        private string _moneyReference2;
        private string _moneyReference3;
        private string _saleCondition;
        private decimal _totalInvoice;
        private decimal _totalMoneyRef1;
        private decimal _totalMoneyRef2;
        private decimal _totalMoneyRef3;
        private int _operationTypeId;
        private int _customerId;
        private int _personId;
        private int _customerAccountId;
        private int _moneyId;
        private int _boxId;
        private int _shopId;
        private decimal _exchange;
        private string _moneyName;
        private string _moneySymbol;

        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }

        public string CustomerRUC { get => _customerRUC; set => SetProperty(ref _customerRUC, value); }

        public string SaleCondition { get => _saleCondition; set => SetProperty(ref _saleCondition, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public string CreditLimit { get => _creditLimit; set => SetProperty(ref _creditLimit, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public int CustomerAccountId { get => _customerAccountId; set => SetProperty(ref _customerAccountId, value); }

        public int PersonId { get => _personId; set => SetProperty(ref _personId, value); }

        public string CustomerAccountName { get => _customerAccountName; set => SetProperty(ref _customerAccountName, value); }

        public decimal TotalInvoice { get => _totalInvoice; set => SetProperty(ref _totalInvoice, value); }

        public decimal TotalMoneyRef1 { get => _totalMoneyRef1; set => SetProperty(ref _totalMoneyRef1, value); }

        public decimal TotalMoneyRef2 { get => _totalMoneyRef2; set => SetProperty(ref _totalMoneyRef2, value); }

        public decimal TotalMoneyRef3 { get => _totalMoneyRef3; set => SetProperty(ref _totalMoneyRef3, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string MoneyReference1 { get => _moneyReference1; set => SetProperty(ref _moneyReference1, value); }

        public string MoneyReference2 { get => _moneyReference2; set => SetProperty(ref _moneyReference2, value); }

        public string MoneyReference3 { get => _moneyReference3; set => SetProperty(ref _moneyReference3, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }
    }
}