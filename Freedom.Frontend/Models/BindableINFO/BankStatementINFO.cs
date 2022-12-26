using System;
using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class BankStatementINFO : BindableBase, IBankStatementRTO
    {
        private DateTime _postedDate;
        private DateTime _paymentDate;
        private string _opType;
        private long _dockNumber;
        private int _id;
        private int _companyId;
        private int _bankAccountId;
        private int _operationTypeId;
        private bool _isDeferredCheck;
        private decimal _debit;
        private decimal _credit;

        private string _concept;
        private bool _status;
        private decimal _previousBalance;

        public DateTime PostedDate { get => _postedDate; set => SetProperty(ref _postedDate, value); }

        public DateTime PaymentDate { get => _paymentDate; set => SetProperty(ref _paymentDate, value); }

        public string OpType { get => _opType; set => SetProperty(ref _opType, value); }

        public long DockNumber { get => _dockNumber; set => SetProperty(ref _dockNumber, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int BankAccountId { get => _bankAccountId; set => SetProperty(ref _bankAccountId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public bool IsDeferredCheck { get => _isDeferredCheck; set => SetProperty(ref _isDeferredCheck, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public decimal Debit
        {
            get => _debit; set
            {
                SetProperty(ref _debit, value);
                RaisePropertyChanged(nameof(this.Balance));
            }
        }

        public decimal Credit
        {
            get => _credit; set
            {
                SetProperty(ref _credit, value);
                RaisePropertyChanged(nameof(this.Balance));
            }
        }

        public decimal Balance
        {
            get
            {
                return (_previousBalance + _credit) - _debit;
            }
        }

        public decimal PreviousBalance
        {
            get => _previousBalance;
            set
            {
                SetProperty(ref _previousBalance, value);
                RaisePropertyChanged(nameof(this.Balance));
            }
        }
    }
}