using Freedom.Frontend.Models.Bindable;
using Freedom.Utility.Bindable;
using System;
using System.Collections.ObjectModel;

namespace Freedom.Frontend.Models.AllPurpose
{
   
    public class FinancingFees : BindableBase
    {
        private int _dividerPerDay = 36000;
        private decimal _totalAmount;
        private decimal _delivery;
        private int _feesQuantity;
        private DateTime _firstMaturity;
        private decimal _annualInterestPercent;

        private ObservableCollection<FeesDetails> _feesDetails;
        private int _termInDays;
        private MoneyBind _moneyBind;

        public FinancingFees(MoneyBind moneyBind)
        {
            FeesDetails = new ObservableCollection<FeesDetails>();
            MoneyBind = moneyBind;
        }

        public FinancingFees()
        {
            FeesDetails = new ObservableCollection<FeesDetails>();
            MoneyBind = new MoneyBind();
        }

        /// <summary>
        /// Total del Monto que vamos financiar
        /// </summary>
        public decimal TotalAmount
        {
            get => _totalAmount;
            set
            {
                SetProperty(ref _totalAmount, value);
                RaisePropertyChanged(nameof(BalanceToFinance));
                RaisePropertyChanged(nameof(InterestTotal));
            }
        }

        /// <summary>
        /// Entrega Inicial
        /// </summary>
        public decimal Delivery
        {
            get => _delivery;
            set
            {
                SetProperty(ref _delivery, value);
                RaisePropertyChanged(nameof(BalanceToFinance));
                RaisePropertyChanged(nameof(InterestTotal));
            }
        }

        /// <summary>
        /// Cantidad de Cuotas
        /// </summary>
        public int FeesQuantity
        {
            get => _feesQuantity;
            set
            {
                SetProperty(ref _feesQuantity, value);
                RaisePropertyChanged(nameof(InterestTotal));
            }
        }

        /// <summary>
        /// primer vencimiento
        /// </summary>
        public DateTime FirstMaturity
        {
            get => _firstMaturity;
            set => SetProperty(ref _firstMaturity, value);
        }

        /// <summary>
        /// Porcentaje de Interes
        /// </summary>
        public decimal AnnualInterestPercent
        {
            get => _annualInterestPercent;
            set
            {
                SetProperty(ref _annualInterestPercent, value);
                RaisePropertyChanged(nameof(InterestTotal));
            }
        }

        /// <summary>
        /// Plazo En Dias
        /// </summary>
        public int TermInDays
        {
            get => _termInDays;
            set
            {
                SetProperty(ref _termInDays, value);
                RaisePropertyChanged(nameof(InterestTotal));
            }
        }

        /// <summary>
        /// Saldo para a finaciar
        /// </summary>
        public decimal BalanceToFinance
        {
            get
            {
                return TotalAmount - Delivery;
            }
        }

        /// <summary>
        /// Valor total del interes
        /// </summary>
        public decimal InterestTotal
        {
            get
            {
                int totaldays = TermInDays * FeesQuantity;
                decimal result = ((BalanceToFinance * AnnualInterestPercent * (decimal)totaldays) / _dividerPerDay);
                return (result <= 0) ? 0 : result;
            }
        }

        public ObservableCollection<FeesDetails> FeesDetails
        {
            get => _feesDetails;
            set => SetProperty(ref _feesDetails, value);
        }

        public MoneyBind MoneyBind { get => _moneyBind; set => SetProperty(ref _moneyBind, value); }
    }
}

//  Mensual = 30 días
//  Bimensual = 60 días
//  Trimestral = 90 díase
//  Cuatrimestral = 120 días
//  Semestral = 180 días

//      calculo de interes simple

//      Capital x taza-de-interes x Dias
// I= --------------------------------------
//              36000
//
//     Capital x taza-de-interes x meses
// I= --------------------------------------
//              1200

//     Capital x taza-de-interes x anhos
// I= --------------------------------------
//               100