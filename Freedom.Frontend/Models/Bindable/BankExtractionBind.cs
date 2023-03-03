using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankExtractionBind : BindableBase
    {
        private int _id;
        private int _companyId;
        private int _bankAccountId;
        private int _bankId;
        private int _operationTypeId;
        private bool _isDeferredCheck;
        private Guid _userId;
        private string _postedDate;
        private string _paymentDate;
        private string _checkNumber;
        private string _amount;
        private string _payee;
        private bool _status;
        private string _bankName;
        private string _accountHolder;
        private string _moneyName;
        private string _accountTypeName;
        private string _accountNumber;
        private string _operationTypeName;
        private string _concept;
        private int _moneyId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int BankAccountId { get => _bankAccountId; set => SetProperty(ref _bankAccountId, value); }

        public int BankId { get => _bankId; set => SetProperty(ref _bankId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public bool IsDeferredCheck { get => _isDeferredCheck; set => SetProperty(ref _isDeferredCheck, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public string PostedDate { get => _postedDate; set => SetProperty(ref _postedDate, value); }

        public string PaymentDate { get => _paymentDate; set => SetProperty(ref _paymentDate, value); }

        public string CheckNumber { get => _checkNumber; set => SetProperty(ref _checkNumber, value); }

        public string Amount { get => _amount; set => SetProperty(ref _amount, value); }

        public string Payee { get => _payee; set => SetProperty(ref _payee, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public string BankName { get => _bankName; set => SetProperty(ref _bankName, value); }

        public string AccountHolder { get => _accountHolder; set => SetProperty(ref _accountHolder, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string AccountTypeName { get => _accountTypeName; set => SetProperty(ref _accountTypeName, value); }

        public string AccountNumber { get => _accountNumber; set => SetProperty(ref _accountNumber, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }
    }
}