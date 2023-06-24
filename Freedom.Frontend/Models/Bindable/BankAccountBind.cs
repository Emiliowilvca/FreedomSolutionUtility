using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankAccountBind : BindableBase, IBankAccount
    {
        private int _id;
        private int _companyId;
        private int _bankId;
        private int _moneyId;
        private int _bankAccountTypeId;
        private string _accountNum;
        private string _accountHolder;
        private string _creditOfficer;
        private string _agency;
        private string _phone;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int BankId { get => _bankId; set => SetProperty(ref _bankId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int BankAccountTypeId { get => _bankAccountTypeId; set => SetProperty(ref _bankAccountTypeId, value); }

        public string AccountNum { get => _accountNum; set => SetProperty(ref _accountNum, value); }

        public string AccountHolder { get => _accountHolder; set => SetProperty(ref _accountHolder, value); }

        public string CreditOfficer { get => _creditOfficer; set => SetProperty(ref _creditOfficer, value); }

        public string Agency { get => _agency; set => SetProperty(ref _agency, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }
    }
}