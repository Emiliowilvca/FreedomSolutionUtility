using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankDepositBind : BindableBase, IBankDepositRTO
    {
        private decimal _totalCash;
        private long _depositNumber;
        private string _bankAccount;
        private string _concept;
        private string _operationTypeName;
        private string _bankName;
        private string _accountHolder;
        private string _moneyName;
        private decimal _totalCheck;
        private DateTime _transactionDate;
        private int _id;
        private int _companyId;
        private Guid _userId;
        private int _bankAccountId;
        private bool _status;
        private int _operationTypeId;
        private int _moneyId;
        private string _opInitials;
        private string _moneySymbol;
        private decimal _totalAmount;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public DateTime TransactionDate { get => _transactionDate; set => SetProperty(ref _transactionDate, value); }

        public decimal TotalCash
        {
            get => _totalCash;
            set
            {
                SetProperty(ref _totalCash, value);
                RaisePropertyChanged(nameof(TotalDeposit));
                RaisePropertyChanged(nameof(TotalCashDecimal));
            }
        }

        public decimal TotalCashDecimal => _totalCash;

        public decimal TotalCheck
        {
            get => _totalCheck;
            set
            {
                SetProperty(ref _totalCheck, value);
                RaisePropertyChanged(nameof(TotalDeposit));
            }
        }

        public long DepositNumber { get => _depositNumber; set => SetProperty(ref _depositNumber, value); }

        public int BankAccountId { get => _bankAccountId; set => SetProperty(ref _bankAccountId, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string AccountHolder { get => _accountHolder; set => SetProperty(ref _accountHolder, value); }

        public string BankAccount { get => _bankAccount; set => SetProperty(ref _bankAccount, value); }

        public string BankName { get => _bankName; set => SetProperty(ref _bankName, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }

        public decimal TotalDeposit
        {
            get
            {
                return TotalCash + TotalCheck;
            }
        }

        public string OpInitials { get => _opInitials; set => SetProperty(ref _opInitials, value); }

        public string MoneySymbol { get => _moneySymbol; set => _moneySymbol = value; }

        public decimal TotalAmount { get => _totalAmount; set => _totalAmount = value; }
    }
}