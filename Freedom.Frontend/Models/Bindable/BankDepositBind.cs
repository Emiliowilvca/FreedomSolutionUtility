using Freedom.Utility;
using Freedom.Utility.Bindable;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankDepositBind : BindableBase
    {
        private string _totalCash;
        private string _depositNumber;
        private string _bankAccount;
        private string _concept;
        private string _operationTypeName;
        private string _bankName;
        private string _accountHolder;
        private string _moneyName;
        private decimal _totalCheck;
        private string _transactionDate;
        private int _id;
        private int _companyId;
        private Guid _userId;
        private int _bankAccountId;
        private bool _status;
        private int _operationTypeId;
        private int _moneyId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public string TransactionDate { get => _transactionDate; set => SetProperty(ref _transactionDate, value); }

        public string TotalCash
        {
            get => _totalCash;
            set
            {
                SetProperty(ref _totalCash, value);
                RaisePropertyChanged(nameof(TotalDeposit));
                RaisePropertyChanged(nameof(TotalCashDecimal));
            }
        }

        public decimal TotalCashDecimal => NumericHelper.ToDecimal(_totalCash);

        public decimal TotalCheck
        {
            get => _totalCheck;
            set
            {
                SetProperty(ref _totalCheck, value);
                RaisePropertyChanged(nameof(TotalDeposit));
            }
        }

        public string DepositNumber { get => _depositNumber; set => SetProperty(ref _depositNumber, value); }

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
                decimal efe = NumericHelper.ToDecimal(TotalCash);
                return efe + TotalCheck;
            }
        }

        public override void ResetEntity()
        {
            base.ResetEntity();
            AccountHolder = "";
            BankAccount = "";
            BankName = "";
            CompanyId = 0;
            Concept = "";
            DepositNumber = "";
            Id = 0;
            MoneyName = "";
            OperationTypeName = "";
            TotalCash = "";
            TotalCheck = 0m;
            TransactionDate = "";
            UserId = default;
            BankAccountId = 0;
            Status = false;
            OperationTypeId = 0;
        }
    }
}