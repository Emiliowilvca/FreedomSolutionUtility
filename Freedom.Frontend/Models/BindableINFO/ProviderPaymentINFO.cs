using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class ProviderPaymentINFO : BindableBase, IProviderPaymentRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private DateTime _datePayment;
        private string _remark;
        private decimal _totalPayment;
        private decimal _totalInterest;
        private decimal _exchange;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public DateTime DatePayment { get => _datePayment; set => SetProperty(ref _datePayment, value); }

        public string Remark { get => _remark; set => SetProperty(ref _remark, value); }

        public decimal TotalPayment { get => _totalPayment; set => SetProperty(ref _totalPayment, value); }

        public decimal TotalInterest { get => _totalInterest; set => SetProperty(ref _totalInterest, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }
    }
}