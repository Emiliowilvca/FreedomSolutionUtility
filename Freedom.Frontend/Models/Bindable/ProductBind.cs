using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class ProductBind :  BindableBase
    {
        private bool _activeProduct;
        private bool _alterStock;
        private bool _isService;
        private bool _payTax;
        private bool _proCheck;
        private bool _wholesaler;
        private int _brandId;
        private int _companyId;
        private int _groupId;
        private int _id;
        private int _measureId;
        private int _moneyId;
        private int _packageId;
        private int _priorityId;
        private int _sectorId;
        private int _shopId;
        private int _sourceId;
        private int _subgroupId;
        private string _advantage;
        private string _barcode;
        private string _benefit;
        private string _brandName;
        private string _code;
        private string _codeProvider;
        private string _column;
        private string _comissionSale;
        private string _costPrice;
        private string _feature;
        private string _genericName;
        private string _groupName;
        private string _line;
        private string _maxDiscount;
        private string _measureName;
        private string _name;
        private string _packageName;
        private string _priorityName;
        private string _productExpiration;
        private string _quantityBox;
        private string _salePrice;
        private string _sectorName;
        private string _shelving;
        private string _side;
        private string _sourceName;
        private string _stockMax;
        private string _stockMin;
        private string _stockQuantity;
        private string _subGroupName;
        private string _taxRate;
        private string _weight;

        /// </summary>
        /// </summary>
        /// <summary>
        /// <summary>
        /// Estanteria numero
        /// Lado de la estanteria
        public bool ActiveProduct { get => _activeProduct; set => SetProperty(ref _activeProduct, value); }

        public bool AlterStock { get => _alterStock; set => SetProperty(ref _alterStock, value); }

        public bool IsService { get => _isService; set => SetProperty(ref _isService, value); }

        public bool PayTax { get => _payTax; set => SetProperty(ref _payTax, value); }

        public bool ProCheck { get => _proCheck; set => SetProperty(ref _proCheck, value); }

        public bool Wholesaler { get => _wholesaler; set => SetProperty(ref _wholesaler, value); }

        public int BrandId { get => _brandId; set => SetProperty(ref _brandId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int GroupId { get => _groupId; set => SetProperty(ref _groupId, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int MeasureId { get => _measureId; set => SetProperty(ref _measureId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public int PackageId { get => _packageId; set => SetProperty(ref _packageId, value); }

        public int PriorityId { get => _priorityId; set => SetProperty(ref _priorityId, value); }

        public int SectorId { get => _sectorId; set => SetProperty(ref _sectorId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int SourceId { get => _sourceId; set => SetProperty(ref _sourceId, value); }

        public int SubgroupId { get => _subgroupId; set => SetProperty(ref _subgroupId, value); }

        public string Advantage { get => _advantage; set => SetProperty(ref _advantage, value); }

        public string Barcode { get => _barcode; set => SetProperty(ref _barcode, value); }

        public string Benefit { get => _benefit; set => SetProperty(ref _benefit, value); }

        public string BrandName { get => _brandName; set => SetProperty(ref _brandName, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string CodeProvider { get => _codeProvider; set => SetProperty(ref _codeProvider, value); }

        public string Column { get => _column; set => SetProperty(ref _column, value); }

        public string ComissionSale { get => _comissionSale; set => SetProperty(ref _comissionSale, value); }

        public string CostPrice { get => _costPrice; set => SetProperty(ref _costPrice, value); }

        public string Feature { get => _feature; set => SetProperty(ref _feature, value); }

        public string GenericName { get => _genericName; set => SetProperty(ref _genericName, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }

        public string Line { get => _line; set => SetProperty(ref _line, value); }

        public string MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public string MeasureName { get => _measureName; set => SetProperty(ref _measureName, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string PackageName { get => _packageName; set => SetProperty(ref _packageName, value); }

        public string PriorityName { get => _priorityName; set => SetProperty(ref _priorityName, value); }

        public string ProductExpiration { get => _productExpiration; set => SetProperty(ref _productExpiration, value); }

        public string QuantityBox { get => _quantityBox; set => SetProperty(ref _quantityBox, value); }

        public string SalePrice { get => _salePrice; set => SetProperty(ref _salePrice, value); }

        public string SectorName { get => _sectorName; set => SetProperty(ref _sectorName, value); }

        public string Shelving { get => _shelving; set => SetProperty(ref _shelving, value); }

        public string Side { get => _side; set => SetProperty(ref _side, value); }

        public string SourceName { get => _sourceName; set => SetProperty(ref _sourceName, value); }

        public string StockMax { get => _stockMax; set => SetProperty(ref _stockMax, value); }

        public string StockMin { get => _stockMin; set => SetProperty(ref _stockMin, value); }

        public string StockQuantity { get => _stockQuantity; set => SetProperty(ref _stockQuantity, value); }

        public string SubGroupName { get => _subGroupName; set => SetProperty(ref _subGroupName, value); }

        public string TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public string Weight { get => _weight; set => SetProperty(ref _weight, value); }


    
    }
}