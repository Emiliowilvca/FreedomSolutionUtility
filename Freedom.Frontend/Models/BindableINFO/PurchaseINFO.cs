using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class PurchaseINFO : BindableBase, IPurchaseRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private DateTime _purchaseDate;
        private long _invoiceNum;
        private string _providerName;
        private string _operationTypeName;
        private string _moneyName;
        private decimal _totalIva;
        private decimal _totalExenta;
        private decimal _totalGravada;
        private decimal _totalNeto;
        private decimal _exchange;
        private bool _retentionExport;
        private decimal _totalRetention;
        private decimal _total;
        private decimal _totalTax;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public DateTime PurchaseDate { get => _purchaseDate; set => SetProperty(ref _purchaseDate, value); }

        public long InvoiceNum { get => _invoiceNum; set => SetProperty(ref _invoiceNum, value); }

        public string ProviderName { get => _providerName; set => SetProperty(ref _providerName, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public decimal TotalIva
        {
            get => _totalIva;
            set
            {
                SetProperty(ref _totalIva, value);
                RaisePropertyChanged(nameof(TotalIvaToLM));
            }
        }

        public decimal TotalExenta
        {
            get => _totalExenta;
            set
            {
                SetProperty(ref _totalExenta, value);
                RaisePropertyChanged(nameof(TotalExentaToLM));
            }
        }

        public decimal TotalGravada
        {
            get => _totalGravada;
            set
            {
                SetProperty(ref _totalGravada, value);
                RaisePropertyChanged(nameof(TotalGravadaToLM));
            }
        }

        public decimal TotalNeto
        {
            get => _totalNeto;
            set
            {
                SetProperty(ref _totalNeto, value);
                RaisePropertyChanged(nameof(TotalNetoToLM));
            }
        }

        public decimal TotalRetention { get => _totalRetention; set => SetProperty(ref _totalRetention, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public bool RetentionExport { get => _retentionExport; set => SetProperty(ref _retentionExport, value); }

        public decimal TotalNetoToLM
        {
            get
            {
                return TotalNeto * Exchange;
            }
        }

        public decimal TotalExentaToLM
        {
            get
            {
                return TotalExenta * Exchange;
            }
        }

        public decimal TotalGravadaToLM
        {
            get
            {
                return TotalGravada * Exchange;
            }
        }

        public decimal TotalIvaToLM
        {
            get
            {
                return TotalIva * Exchange;
            }
        }

        public decimal Total { get => _total; set => SetProperty(ref _total, value); }

        public decimal TotalTax { get => _totalTax; set => SetProperty(ref _totalTax, value); }
    }
}