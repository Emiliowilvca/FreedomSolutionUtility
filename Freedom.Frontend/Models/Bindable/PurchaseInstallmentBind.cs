using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class PurchaseInstallmentBind : BindableBase, IPurchaseInstallmentRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _purchaseId;
        private int _providerId;
        private decimal _capital;
        private decimal _interest;
        private decimal _feesvalue;
        private int _moneyId;
        private bool _status;
        private DateTime _expirate;
        private decimal _exchange;
        private int _feeIndex;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int FeeIndex { get => _feeIndex; set => SetProperty(ref _feeIndex, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public decimal Capital { get => _capital; set => SetProperty(ref _capital, value); }

        public decimal Interest { get => _interest; set => SetProperty(ref _interest, value); }

        public decimal Feesvalue { get => _feesvalue; set => SetProperty(ref _feesvalue, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public DateTime Expirate { get => _expirate; set => SetProperty(ref _expirate, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}