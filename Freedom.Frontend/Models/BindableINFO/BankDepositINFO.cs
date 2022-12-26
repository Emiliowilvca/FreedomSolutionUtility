using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class BankDepositINFO : BindableBase, IBankDepositRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private DateTime _transactionDate;
        private long _depositNumber;
        private string _opInitials;
        private string _moneySymbol;
        private string _bankAccount;
        private string _concept;
        private decimal _totalCash;
        private decimal _totalCheck;
        private decimal _totalAmount;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public DateTime TransactionDate { get => _transactionDate; set => SetProperty(ref _transactionDate, value); }

        public long DepositNumber { get => _depositNumber; set => SetProperty(ref _depositNumber, value); }

        public string OpInitials { get => _opInitials; set => SetProperty(ref _opInitials, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string BankAccount { get => _bankAccount; set => SetProperty(ref _bankAccount, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public decimal TotalCash { get => _totalCash; set => SetProperty(ref _totalCash, value); }

        public decimal TotalCheck { get => _totalCheck; set => SetProperty(ref _totalCheck, value); }

        public decimal TotalAmount { get => _totalAmount; set => SetProperty(ref _totalAmount, value); }
    }
}