using Freedom.Utility.Bindable;
using System;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class FeesDetails : BindableBase
    {
        private decimal _lastBalance;
        private int _level;
        private DateTime _expiration;
        private decimal _capital;
        private decimal _interest;
        private string _moneySymbol;
        private DateTime _currentDay;

        public int Level { get => _level; set => SetProperty(ref _level, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public DateTime CurrentDay { get => _currentDay; set => _currentDay = value; }

        public decimal Capital
        {
            get => _capital;
            set
            {
                SetProperty(ref _capital, value);
                RaisePropertyChanged(nameof(this.Balance));
                RaisePropertyChanged(nameof(this.FeeTotal));
            }
        }

        public decimal Interest
        {
            get => _interest;
            set
            {
                SetProperty(ref _interest, value);
                RaisePropertyChanged(nameof(Balance));
                RaisePropertyChanged(nameof(FeeTotal));
            }
        }

        /// <summary>
        /// Dias de Atraso
        /// </summary>
        public double Delay
        {
            get
            {
                return CurrentDay.Subtract(Expiration).Days;
            }
        }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public decimal LastBalance
        {
            get => _lastBalance;
            set
            {
                SetProperty(ref _lastBalance, value);
                RaisePropertyChanged(nameof(Balance));
            }
        }

        /// <summary>
        /// Valor de Cuotas ( Capital + interes )
        /// </summary>
        public decimal FeeTotal
        {
            get
            {
                return Capital + Interest;
            }
        }

        /// <summary>
        /// Saldo de cada Cuota [ LastBalance - (Capital + Interest) ]
        /// </summary>
        public decimal Balance
        {
            get
            {
                return LastBalance - (Capital + Interest);
            }
        }
    }
}