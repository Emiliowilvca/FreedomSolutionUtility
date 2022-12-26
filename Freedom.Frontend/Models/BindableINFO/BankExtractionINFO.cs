using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class BankExtractionINFO : BindableBase, IBankExtractionRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _bankAccountId;
        private int _bankId;
        private int _operationTypeId;
        private bool _isDeferredCheck;
        private Guid _userId;
        private DateTime _postedDate;
        private DateTime _paymentDate;
        private long _checkNumber;
        private decimal _amount;
        private string _payee;
        private string _concept;
        private bool _status;
        private bool _isSelected;
        private string _opType;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int BankAccountId { get => _bankAccountId; set => SetProperty(ref _bankAccountId, value); }

        public int BankId { get => _bankId; set => SetProperty(ref _bankId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public bool IsDeferredCheck { get => _isDeferredCheck; set => SetProperty(ref _isDeferredCheck, value); }

        public string OpType { get => _opType; set => SetProperty(ref _opType, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public DateTime PostedDate { get => _postedDate; set => SetProperty(ref _postedDate, value); }

        public DateTime PaymentDate { get => _paymentDate; set => SetProperty(ref _paymentDate, value); }

        public long CheckNumber { get => _checkNumber; set => SetProperty(ref _checkNumber, value); }

        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }

        public string Payee { get => _payee; set => SetProperty(ref _payee, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}