using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class MoneyBind : BindableBase, IMoney, ISelectable
    {
        private int _id;
        private string _name;
        private int _companyId;
        private int _decimalPlaces;
        private decimal _exchange;
        private string _isoCode;
        private bool _moneyBase;
        private string _symbol;
        private decimal _commisionPercent;
        private bool _isSelected;
        private int _defaultCustomerAccountId;
        private int _defaultCustomerId;
        private int _defaultPersonId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
        public int DecimalPlaces { get => _decimalPlaces; set => SetProperty(ref _decimalPlaces, value); }
        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }
        public string IsoCode { get => _isoCode; set => SetProperty(ref _isoCode, value); }
        public bool MoneyBase { get => _moneyBase; set => SetProperty(ref _moneyBase, value); }
        public string Symbol { get => _symbol; set => SetProperty(ref _symbol, value); }
        public decimal CommisionPercent { get => _commisionPercent; set => SetProperty(ref _commisionPercent, value); }
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int DefaultCustomerAccountId { get => _defaultCustomerAccountId; set => SetProperty(ref _defaultCustomerAccountId, value); }

        public int DefaultCustomerId { get => _defaultCustomerId; set => SetProperty(ref _defaultCustomerId, value); }

        public int DefaultPersonId { get => _defaultPersonId; set => SetProperty(ref _defaultPersonId, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            Name = "";
            CompanyId = 0;
            DecimalPlaces = 0;
            Exchange = 0.0M;
            IsoCode = "";
            MoneyBase = false;
            Symbol = "";
            CommisionPercent = 0.0M;
            IsSelected = false;
            DefaultCustomerAccountId = 0;
            DefaultCustomerId = 0;
            DefaultPersonId = 0;
        }

        public override object Clone()
        {
            MoneyBind moneyBind = (MoneyBind)this.MemberwiseClone();
            return moneyBind;
        }
    }
}