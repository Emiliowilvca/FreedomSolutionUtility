using Freedom.Frontend.Models.BaseBindableInterface;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class PayOffCalculatorBind : BindableBase, IPayOffCalculator
    {
        private decimal _loanAmount;
        private decimal _amountDelivery;
        private decimal _balanceOwed;
        private int _termType;
        private int _feesCount;
        private DateTime _startDate;
        private string _moneyName;
        private string _moneySymbol;
        private string _companyName;
        private string _shopName;
        private string _shopAddress;
        private string _shopPhone;
        private string _userName;
        private string _boxName;
        private string _businessName;
        private int _operationTypeId;
        private string _operationTypeName;

        public decimal LoanAmount { get => _loanAmount; set => SetProperty(ref _loanAmount, value); }

        public decimal AmountDelivery { get => _amountDelivery; set => SetProperty(ref _amountDelivery, value); }

        public decimal BalanceOwed { get => _balanceOwed; set => SetProperty(ref _balanceOwed, value); }

        public int TermType { get => _termType; set => SetProperty(ref _termType, value); }

        public int FeesCount { get => _feesCount; set => SetProperty(ref _feesCount, value); }

        public DateTime StartDate { get => _startDate; set => SetProperty(ref _startDate, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string CompanyName { get => _companyName; set => SetProperty(ref _companyName, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public string ShopAddress { get => _shopAddress; set => SetProperty(ref _shopAddress, value); }

        public string ShopPhone { get => _shopPhone; set => SetProperty(ref _shopPhone, value); }

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public string BusinessName { get => _businessName; set => SetProperty(ref _businessName, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }

        public void GetEntity(IPayOffCalculator p)
        {
            LoanAmount = p.LoanAmount;
            AmountDelivery = p.AmountDelivery;
            BalanceOwed = p.BalanceOwed;
            TermType = p.TermType;
            FeesCount = p.FeesCount;
            StartDate = p.StartDate;
            MoneyName = p.MoneyName;
            MoneySymbol = p.MoneySymbol;
            CompanyName = p.CompanyName;
            ShopName = p.ShopName;
            ShopAddress = p.ShopAddress;
            ShopPhone = p.ShopPhone;
            UserName = p.UserName;
            BoxName = p.BoxName;
            BusinessName = p.BusinessName;
            OperationTypeId = p.OperationTypeId;
            OperationTypeName = p.OperationTypeName;
        }
    }
}