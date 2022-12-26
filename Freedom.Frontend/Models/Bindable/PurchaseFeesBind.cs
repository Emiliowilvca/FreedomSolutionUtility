using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class PurchaseFeesBind : BindableBase, IPurchaseFees
    {
        private int _id;
        private int _companyId;
        private int _purchaseId;
        private byte _numberFees;
        private int _providerId;
        private decimal _capital;
        private decimal _interest;
        private decimal _feesvalue;
        private int _moneyId;
        private bool _status;
        private DateTime _expirate;
        private decimal _exchange;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public byte NumberFees { get => _numberFees; set => SetProperty(ref _numberFees, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public decimal Capital { get => _capital; set => SetProperty(ref _capital, value); }

        public decimal Interest { get => _interest; set => SetProperty(ref _interest, value); }

        public decimal Feesvalue { get => _feesvalue; set => SetProperty(ref _feesvalue, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public DateTime Expirate { get => _expirate; set => SetProperty(ref _expirate, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }
    }
}