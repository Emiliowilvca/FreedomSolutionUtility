using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class ProviderDebtDetailBind : PurchaseBind, IProviderDebtDetailRTO
    {
        private int _purchaseId;
        private int _purchaseFeesId;
        private string _moneySymbol;
        private int _employeeId;
        private string _employeeName;
        private decimal _feesvalue;
        private decimal _partialPayment;
        private decimal _balanceFees;
        private decimal _imputValue;
        private DateTime _expirate;
        private byte _numberFees;
        private decimal _daysLate;

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int PurchaseFeesId { get => _purchaseFeesId; set => SetProperty(ref _purchaseFeesId, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }

        public decimal Feesvalue { get => _feesvalue; set => SetProperty(ref _feesvalue, value); }

        public decimal PartialPayment { get => _partialPayment; set => SetProperty(ref _partialPayment, value); }

        public decimal BalanceFees { get => _balanceFees; set => SetProperty(ref _balanceFees, value); }

        public decimal ImputValue { get => _imputValue; set => SetProperty(ref _imputValue, value); }

        public DateTime Expirate { get => _expirate; set => SetProperty(ref _expirate, value); }

        public byte NumberFees { get => _numberFees; set => SetProperty(ref _numberFees, value); }

        public decimal DaysLate { get => _daysLate; set => SetProperty(ref _daysLate, value); }
    }
}