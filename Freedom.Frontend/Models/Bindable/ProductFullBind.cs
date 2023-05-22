using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Obsolete("use Product Bind",true)]
    public class ProductFullBind : BindableBase, IProductFullRTO
    {
        private int _id;
        private int _brandId;
        private int _companyId;
        private int _groupId;
        private int _measureId;
        private int _packageId;
        private int _priorityId;
        private int _sourceId;
        private int _subgroupId;
        private string _advantage;
        private string _barcode;
        private string _benefit;
        private string _code;
        private string _codeProvider;
        private string _feature;
        private string _genericName;
        private string _name;
        private decimal _comissionSale;
        private decimal _maxDiscount;
        private decimal _quantityBox;
        private decimal _stockMax;
        private decimal _stockMin;
        private decimal _taxRate;
        private decimal _weight;
        private bool _alterStock;
        private bool _isService;
        private bool _payTax;
        private bool _proCheck;
        private bool _wholesaler;
        private decimal _salePrice;
        private decimal _costPrice;
        private int _moneyId;
        private decimal _exchange;
        private int _shopId;
        private decimal _stockQuantity;
        private string _subGroupName;
        private string _measureName;
        private string _packageName;
        private string _priorityName;
        private string _sourceName;
        private string _brandName;
        private string _groupName;
        private short _priceLevel;
        private short _priceQuantity;
        private byte _typePrice;
        private string _moneyName;
        private int _stockId;
        private string _lote;
        private DateTime _manufactory;
        private DateTime _expiration;
        private int _shelvingSectorId;
        private int _shelving;
        private int _shelvingSide;
        private int _shelvingColumn;
        private int _shelvingLine;
        private bool _isActive;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int BrandId { get => _brandId; set => SetProperty(ref _brandId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int GroupId { get => _groupId; set => SetProperty(ref _groupId, value); }

        public int MeasureId { get => _measureId; set => SetProperty(ref _measureId, value); }

        public int PackageId { get => _packageId; set => SetProperty(ref _packageId, value); }

        public int PriorityId { get => _priorityId; set => SetProperty(ref _priorityId, value); }

        public int SourceId { get => _sourceId; set => SetProperty(ref _sourceId, value); }

        public int SubgroupId { get => _subgroupId; set => SetProperty(ref _subgroupId, value); }

        public string Advantage { get => _advantage; set => SetProperty(ref _advantage, value); }

        public string Barcode { get => _barcode; set => SetProperty(ref _barcode, value); }

        public string Benefit { get => _benefit; set => SetProperty(ref _benefit, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string CodeProvider { get => _codeProvider; set => SetProperty(ref _codeProvider, value); }

        public string Feature { get => _feature; set => SetProperty(ref _feature, value); }

        public string GenericName { get => _genericName; set => SetProperty(ref _genericName, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public decimal ComissionSale { get => _comissionSale; set => SetProperty(ref _comissionSale, value); }

        public decimal MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public decimal QuantityBox { get => _quantityBox; set => SetProperty(ref _quantityBox, value); }

        public decimal StockMax { get => _stockMax; set => SetProperty(ref _stockMax, value); }

        public decimal StockMin { get => _stockMin; set => SetProperty(ref _stockMin, value); }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public decimal Weight { get => _weight; set => SetProperty(ref _weight, value); }

        public bool AlterStock { get => _alterStock; set => SetProperty(ref _alterStock, value); }

        public bool IsService { get => _isService; set => SetProperty(ref _isService, value); }

        public bool PayTax { get => _payTax; set => SetProperty(ref _payTax, value); }

        public bool ProCheck { get => _proCheck; set => SetProperty(ref _proCheck, value); }

        public bool Wholesaler { get => _wholesaler; set => SetProperty(ref _wholesaler, value); }

        public decimal SalePrice { get => _salePrice; set => SetProperty(ref _salePrice, value); }

        public decimal CostPrice { get => _costPrice; set => SetProperty(ref _costPrice, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public decimal StockQuantity { get => _stockQuantity; set => SetProperty(ref _stockQuantity, value); }

        public string SubGroupName { get => _subGroupName; set => SetProperty(ref _subGroupName, value); }

        public string MeasureName { get => _measureName; set => SetProperty(ref _measureName, value); }

        public string PackageName { get => _packageName; set => SetProperty(ref _packageName, value); }

        public string PriorityName { get => _priorityName; set => SetProperty(ref _priorityName, value); }

        public string SourceName { get => _sourceName; set => SetProperty(ref _sourceName, value); }

        public string BrandName { get => _brandName; set => SetProperty(ref _brandName, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }

        public short PriceLevel { get => _priceLevel; set => SetProperty(ref _priceLevel, value); }

        public short PriceQuantity { get => _priceQuantity; set => SetProperty(ref _priceQuantity, value); }

        public byte TypePrice { get => _typePrice; set => SetProperty(ref _typePrice, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public int StockId { get => _stockId; set => SetProperty(ref _stockId, value); }

        public string Lote { get => _lote; set => SetProperty(ref _lote, value); }

        public DateTime Manufactory { get => _manufactory; set => SetProperty(ref _manufactory, value); }

        public DateTime Expiration { get => _expiration; set => SetProperty(ref _expiration, value); }

        public int ShelvingSectorId { get => _shelvingSectorId; set => SetProperty(ref _shelvingSectorId, value); }

        public int Shelving { get => _shelving; set => SetProperty(ref _shelving, value); }

        public int ShelvingSide { get => _shelvingSide; set => SetProperty(ref _shelvingSide, value); }

        public int ShelvingColumn { get => _shelvingColumn; set => SetProperty(ref _shelvingColumn, value); }

        public int ShelvingLine { get => _shelvingLine; set => SetProperty(ref _shelvingLine, value); }

        public bool IsActive { get => _isActive; set => SetProperty(ref _isActive, value); }
    }
}