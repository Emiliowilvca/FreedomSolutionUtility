using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class PurchaseWithHoldingTaxBind : BindableBase, IPurchaseWithHoldingTax
    {
        private int _id;
        private int _companyId;
        private int _purchaseId;
        private DateTime _dateRetention;
        private string _moneyISO4217;
        private string _condition;
        private string _taxPayerStatus;
        private int _tipoComprobanteId;
        private bool _isRetentionIVA;
        private bool _isRetentionRenta;
        private string _conceptRetentionRenta;
        private string _conceptRetentionTaxIva;
        private decimal _changeType;
        private decimal _totalInvoice;
        private decimal _totalIva5;
        private decimal _totalIva10;
        private decimal _totalExenta;
        private decimal _taxIva5;
        private decimal _taxIva10;
        private decimal _taxTotal;
        private decimal _retentionPercentIva5;
        private decimal _retentionPercentIva10;
        private decimal _retentionPercentRenta;
        private decimal _retentionIva5;
        private decimal _retentionIva10;
        private decimal _retentionRenta;
        private decimal _retentionCabeza;
        private decimal _retentionTonelada;
        private decimal _retentionTotalGeneral;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public DateTime DateRetention { get => _dateRetention; set => SetProperty(ref _dateRetention, value); }

        public string MoneyISO4217 { get => _moneyISO4217; set => SetProperty(ref _moneyISO4217, value); }

        public string Condition { get => _condition; set => SetProperty(ref _condition, value); }

        public string TaxPayerStatus { get => _taxPayerStatus; set => SetProperty(ref _taxPayerStatus, value); }

        public int TipoComprobanteId { get => _tipoComprobanteId; set => SetProperty(ref _tipoComprobanteId, value); }

        public bool IsRetentionIVA
        {
            get => _isRetentionIVA;
            set
            {
                SetProperty(ref _isRetentionIVA, value);
                RefreshChanges();
            }
        }

        public bool IsRetentionRenta
        {
            get => _isRetentionRenta;
            set
            {
                SetProperty(ref _isRetentionRenta, value);
                RefreshChanges();
            }
        }

        public string ConceptRetentionRenta { get => _conceptRetentionRenta; set => SetProperty(ref _conceptRetentionRenta, value); }

        public string ConceptRetentionTaxIva { get => _conceptRetentionTaxIva; set => SetProperty(ref _conceptRetentionTaxIva, value); }

        public decimal ChangeType
        {
            get => _changeType;
            set
            {
                SetProperty(ref _changeType, value);
                RefreshChanges();
            }
        }

        //calculos de totales

        public decimal TotalInvoice
        {
            get
            {
                _totalInvoice = TotalExenta + TotalIva10 + TotalIva5;
                return _totalInvoice;
            }
            set => SetProperty(ref _totalInvoice, value);
        }

        public decimal TaxTotal
        {
            get
            {
                _taxTotal = TaxIva5 + TaxIva10;
                return _taxTotal;
            }
            set => SetProperty(ref _taxTotal, value);
        }

        public decimal BaseRetentionRenta => IsRetentionRenta ? (TotalInvoice - TaxTotal) * ChangeType : 0;

        public decimal BaseRetentionIva5 => IsRetentionIVA ? (TaxIva5 * ChangeType) : 0;

        public decimal BaseRetentionIva10 => IsRetentionIVA ? (TaxIva10 * ChangeType) : 0;

        public decimal RetentionIva5
        {
            get
            {
                _retentionIva5 = BaseRetentionIva5 * (RetentionPercentIva5 / 100);
                return _retentionIva5;
            }
            set => SetProperty(ref _retentionIva5, value);
        }

        public decimal RetentionIva10
        {
            get
            {
                _retentionIva10 = BaseRetentionIva10 * (RetentionPercentIva10 / 100);
                return _retentionIva10;
            }
            set => SetProperty(ref _retentionIva10, value);
        }

        public decimal RetentionRenta
        {
            get
            {
                _retentionRenta = BaseRetentionRenta * (RetentionPercentRenta / 100);
                return _retentionRenta;
            }
            set
            {
                SetProperty(ref _retentionRenta, value);
            }
        }

        public decimal RetentionTotalGeneral
        {
            get
            {
                _retentionTotalGeneral = RetentionIva10 + RetentionIva5 + RetentionRenta + RetentionTonelada + RetentionCabeza;
                return _retentionTotalGeneral;
            }
            set => SetProperty(ref _retentionTotalGeneral, value);
        }

        public decimal TotalGravada
        {
            get
            {
                return TotalInvoice - TaxTotal;
            }
        }

        public decimal RetentionPercentIva5
        {
            get => _retentionPercentIva5;
            set
            {
                SetProperty(ref _retentionPercentIva5, value);
                RefreshChanges();
            }
        }

        public decimal RetentionPercentIva10
        {
            get => _retentionPercentIva10;
            set
            {
                SetProperty(ref _retentionPercentIva10, value);
                RefreshChanges();
            }
        }

        public decimal RetentionPercentRenta
        {
            get => _retentionPercentRenta;
            set
            {
                SetProperty(ref _retentionPercentRenta, value);
                RefreshChanges();
            }
        }

        public decimal RetentionCabeza
        {
            get => _retentionCabeza;
            set
            {
                SetProperty(ref _retentionCabeza, value);
                RefreshChanges();
            }
        }

        public decimal RetentionTonelada
        {
            get => _retentionTonelada;
            set
            {
                SetProperty(ref _retentionTonelada, value);
                RefreshChanges();
            }
        }

        public decimal TotalIva5
        {
            get => _totalIva5;
            set
            {
                SetProperty(ref _totalIva5, value);
                RefreshChanges();
            }
        }

        public decimal TotalIva10
        {
            get => _totalIva10;
            set
            {
                SetProperty(ref _totalIva10, value);
                RefreshChanges();
            }
        }

        public decimal TotalExenta
        {
            get => _totalExenta;
            set
            {
                SetProperty(ref _totalExenta, value);
                RefreshChanges();
            }
        }

        public decimal TaxIva5
        {
            get => _taxIva5;
            set
            {
                SetProperty(ref _taxIva5, value);
                RefreshChanges();
            }
        }

        public decimal TaxIva10
        {
            get => _taxIva10;
            set
            {
                SetProperty(ref _taxIva10, value);
                RefreshChanges();
            }
        }

        private void RefreshChanges()
        {
            RaisePropertyChanged(nameof(this.RetentionIva5));
            RaisePropertyChanged(nameof(this.RetentionIva10));
            RaisePropertyChanged(nameof(this.RetentionRenta));
            RaisePropertyChanged(nameof(this.BaseRetentionIva5));
            RaisePropertyChanged(nameof(this.BaseRetentionIva10));
            RaisePropertyChanged(nameof(this.BaseRetentionRenta));
            RaisePropertyChanged(nameof(this.TaxTotal));
            RaisePropertyChanged(nameof(this.TotalInvoice));
            RaisePropertyChanged(nameof(this.RetentionTotalGeneral));
        }

        //reset
        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            PurchaseId = 0;
            DateRetention = DateTime.Now;
            MoneyISO4217 = "";
            Condition = "";
            TaxPayerStatus = "";
            TipoComprobanteId = 0;
            IsRetentionIVA = false;
            IsRetentionRenta = false;
            ConceptRetentionRenta = "";
            ConceptRetentionTaxIva = "";
            ChangeType = 0;
            TotalInvoice = 0;
            TotalIva10 = 0;
            TotalIva5 = 0;
            TotalExenta = 0;
            TaxIva10 = 0;
            TaxIva5 = 0;
            TaxTotal = 0;
            RetentionPercentIva10 = 0;
            RetentionPercentIva5 = 0;
            RetentionPercentRenta = 0;
            RetentionIva10 = 0;
            RetentionIva5 = 0;
            RetentionRenta = 0;
            RetentionTonelada = 0;
            RetentionCabeza = 0;
            RetentionTotalGeneral = 0;
        }

        public override object Clone()
        {
            PurchaseWithHoldingTaxBind purchaseBind = (PurchaseWithHoldingTaxBind)this.MemberwiseClone();
            return purchaseBind;
        }
    }
}