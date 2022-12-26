using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.BindableRequestModels
{
    public class BankDepositRequestBind : BindableBase
    {
        private int _companyId;
        private string _sinceDate;
        private string _untilDate;
        private int _operationTypeId;
        private int _bankAccountId;
        private string _offSet;
        private string _limit;
        private string _bankName;
        private string _accountHolder;
        private string _moneyName;
        private string _operationTypeName;
        private string _bankAccountNumber;

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string SinceDate { get => _sinceDate; set => SetProperty(ref _sinceDate, value); }

        public string UntilDate { get => _untilDate; set => SetProperty(ref _untilDate, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int BankAccountId { get => _bankAccountId; set => SetProperty(ref _bankAccountId, value); }

        public string BankAccountNumber { get => _bankAccountNumber; set => SetProperty(ref _bankAccountNumber, value); }

        public string OffSet { get => _offSet; set => SetProperty(ref _offSet, value); }

        public string Limit { get => _limit; set => SetProperty(ref _limit, value); }

        public string BankName { get => _bankName; set => SetProperty(ref _bankName, value); }

        public string AccountHolder { get => _accountHolder; set => SetProperty(ref _accountHolder, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }
    }
}