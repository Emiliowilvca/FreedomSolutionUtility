using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class MoneyINFO : BindableBase, IMoneyRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;
        private int _decimalPlaces;
        private decimal _exchange;
        private string _isoCode;
        private string _symbol;
        private int _companyId;
        private bool _moneyBase;
        private decimal _commisionPercent;
        private int _defaultCustomerAccountId;
        private int _defaultCustomerId;
        private int _defaultPersonId;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int DecimalPlaces { get => _decimalPlaces; set => SetProperty(ref _decimalPlaces, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public string IsoCode { get => _isoCode; set => SetProperty(ref _isoCode, value); }

        public string Symbol { get => _symbol; set => SetProperty(ref _symbol, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public bool MoneyBase { get => _moneyBase; set => SetProperty(ref _moneyBase, value); }

        public decimal CommisionPercent { get => _commisionPercent; set => SetProperty(ref _commisionPercent, value); }

        public int DefaultCustomerAccountId { get => _defaultCustomerAccountId; set => SetProperty(ref _defaultCustomerAccountId, value); }

        public int DefaultCustomerId { get => _defaultCustomerId; set => SetProperty(ref _defaultCustomerId, value); }

        public int DefaultPersonId { get => _defaultPersonId; set => SetProperty(ref _defaultPersonId, value); }
    }
}