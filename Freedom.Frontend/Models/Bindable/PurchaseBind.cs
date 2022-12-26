using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class PurchaseBind : BindableBase, IPurchase, ISelectable
    {
        private int _id;
        private int _companyId;
        private DateTime _purchaseDate;
        private long _invoiceNum;
        private int _providerId;
        private int _operationTypeId;
        private int _moneyId;
        private Guid _userId;
        private int _shopId;
        private int _boxId;
        private int _carrierId;
        private decimal _totalIva;
        private decimal _totalExenta;
        private decimal _totalGravada;
        private decimal _totalNeto;
        private decimal _importExpence;
        private bool _itsImport;
        private decimal _exchange;
        private bool _status;
        private string _note;
        private ProviderBind _providerBind;
        private OperationTypeBind _operationTypeBind;
        private MoneyBind _moneyBind;
        private CarrierBind _carrierBind;
        private string _timbrado;
        private ObservableCollection<PurchaseFeesBind> _purchaseFeesBindCollection;
        private ObservableCollection<PurchaseWithHoldingTaxBind> _purchaseWithHoldingTaxBindCollection;
        private bool _isSelected;
        private ShopBind _shopBind;
        private BoxBind _boxBind;
        private ObservableCollection<WithholdingTaxExportedBind> _withholdingTaxExportedBindCollection;

        public PurchaseBind()
        {
            ProviderBind = new ProviderBind();
            OperationTypeBind = new OperationTypeBind();
            MoneyBind = new MoneyBind();
            CarrierBind = new CarrierBind();
            PurchaseWithHoldingTaxBindCollection = new ObservableCollection<PurchaseWithHoldingTaxBind>();
            PurchaseFeesBindCollection = new ObservableCollection<PurchaseFeesBind>();
        }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime PurchaseDate { get => _purchaseDate; set => SetProperty(ref _purchaseDate, value); }

        public long InvoiceNum { get => _invoiceNum; set => SetProperty(ref _invoiceNum, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int CarrierId { get => _carrierId; set => SetProperty(ref _carrierId, value); }

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

        public decimal ImportExpence { get => _importExpence; set => SetProperty(ref _importExpence, value); }

        public bool ItsImport { get => _itsImport; set => SetProperty(ref _itsImport, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public bool Status { get => _status; set => SetProperty(ref _status, value); }

        public string Note { get => _note; set => SetProperty(ref _note, value); }

        public string Timbrado { get => _timbrado; set => SetProperty(ref _timbrado, value); }

        public ProviderBind ProviderBind { get => _providerBind; set => SetProperty(ref _providerBind, value); }

        public OperationTypeBind OperationTypeBind { get => _operationTypeBind; set => SetProperty(ref _operationTypeBind, value); }

        public MoneyBind MoneyBind { get => _moneyBind; set => SetProperty(ref _moneyBind, value); }

        public CarrierBind CarrierBind { get => _carrierBind; set => SetProperty(ref _carrierBind, value); }

        public ShopBind ShopBind { get => _shopBind; set => SetProperty(ref _shopBind, value); }

        public BoxBind BoxBind { get => _boxBind; set => SetProperty(ref _boxBind, value); }

        public ObservableCollection<PurchaseWithHoldingTaxBind> PurchaseWithHoldingTaxBindCollection
        {
            get => _purchaseWithHoldingTaxBindCollection;
            set
            {
                SetProperty(ref _purchaseWithHoldingTaxBindCollection, value);
                RaisePropertyChanged(nameof(PurchaseWithHoldingTaxTotalToLM));
            }
        }

        public ObservableCollection<WithholdingTaxExportedBind> WithholdingTaxExportedBindCollection
        {
            get => _withholdingTaxExportedBindCollection;
            set
            {
                SetProperty(ref _withholdingTaxExportedBindCollection, value);
                RaisePropertyChanged(nameof(IsExported));
            }
        }

        public ObservableCollection<PurchaseFeesBind> PurchaseFeesBindCollection
        {
            get => _purchaseFeesBindCollection;
            set => SetProperty(ref _purchaseFeesBindCollection, value);
        }

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

        public decimal PurchaseWithHoldingTaxTotalToLM
        {
            get
            {
                return PurchaseWithHoldingTaxBindCollection.ToList().Sum(x => x.RetentionTotalGeneral);
            }
        }

        public bool IsExported
        {
            get
            {
                bool exp = false;
                if (WithholdingTaxExportedBindCollection != null)
                {
                    exp = WithholdingTaxExportedBindCollection.Count > 0;
                }
                return exp;
            }
        }

        public override void ResetEntity()
        {
            Id = 0;
            CompanyId = 0;
            PurchaseDate = DateTime.Now;
            InvoiceNum = 0;
            ProviderId = 0;
            OperationTypeId = 0;
            MoneyId = 0;
            UserId = default;
            ShopId = 0;
            BoxId = 0;
            CarrierId = 0;
            TotalIva = 0;
            TotalExenta = 0;
            TotalGravada = 0;
            TotalNeto = 0;
            ImportExpence = 0;
            ItsImport = false;
            Exchange = 0;
            Status = true;
            Note = "";
            PurchaseWithHoldingTaxBindCollection?.Clear();
            PurchaseFeesBindCollection?.Clear();
            ProviderBind.ResetEntity();
            OperationTypeBind.ResetEntity();
            MoneyBind.ResetEntity();
            CarrierBind.ResetEntity();
        }
    }
}