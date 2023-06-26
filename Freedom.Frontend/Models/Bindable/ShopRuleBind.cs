using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class ShopRuleBind : BindableBase, IShopRuleRTO
    {
        private string _customerName;
        private string _operTypeCashPurchaseName;
        private string _operTypeCashSaleName;
        private string _operTypeCreditPurchaseName;
        private string _operTypeCreditSaleName;
        private int _id;
        private int _companyId;
        private int _shopId;
        private int _personId;
        private int _customerId;
        private int _customerAccountId;
        private int _decimalInStock;
        private string _encryptPriceKey;
        private decimal _interestRateMonthly;
        private decimal _interestOnArrears;
        private bool _forceSaleIfStockIsZero;
        private bool _grantDiscounts;
        private int _maxItemInSale;
        private int _maxItemInPayment;
        private bool _modifyPriceInSales;
        private int _operTypeCashPurchase;
        private int _operTypeCashSale;
        private int _operTypeCreditPurchase;
        private int _operTypeCreditSale;
        private decimal _maxDiscountPercent;
        private int _installmentPeriod;
        private int _priceLevelDefault;

        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }
      
        public string OperTypeCashPurchaseName { get => _operTypeCashPurchaseName; set => SetProperty(ref _operTypeCashPurchaseName, value); }
        
        public string OperTypeCashSaleName { get => _operTypeCashSaleName; set => SetProperty(ref _operTypeCashSaleName, value); }
        
        public string OperTypeCreditPurchaseName { get => _operTypeCreditPurchaseName; set => SetProperty(ref _operTypeCreditPurchaseName, value); }
        
        public string OperTypeCreditSaleName { get => _operTypeCreditSaleName; set => SetProperty(ref _operTypeCreditSaleName, value); }
        
        public int Id { get => _id; set => SetProperty(ref _id, value); }
        
        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
        
        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }
        
        public int PersonId { get => _personId; set => SetProperty(ref _personId, value); }
        
        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }
        
        public int CustomerAccountId { get => _customerAccountId; set => SetProperty(ref _customerAccountId, value); }
        
        public int DecimalInStock { get => _decimalInStock; set => SetProperty(ref _decimalInStock, value); }
        
        public string EncryptPriceKey { get => _encryptPriceKey; set => SetProperty(ref _encryptPriceKey, value); }
        
        public decimal InterestRateMonthly { get => _interestRateMonthly; set => SetProperty(ref _interestRateMonthly, value); }
        
        public decimal InterestOnArrears { get => _interestOnArrears; set => SetProperty(ref _interestOnArrears, value); }
        
        public bool ForceSaleIfStockIsZero { get => _forceSaleIfStockIsZero; set => SetProperty(ref _forceSaleIfStockIsZero, value); }
        
        public bool GrantDiscounts { get => _grantDiscounts; set => SetProperty(ref _grantDiscounts, value); }
        
        public int MaxItemInSale { get => _maxItemInSale; set => SetProperty(ref _maxItemInSale, value); }
        
        public int MaxItemInPayment { get => _maxItemInPayment; set => SetProperty(ref _maxItemInPayment, value); }
        
        public bool ModifyPriceInSales { get => _modifyPriceInSales; set => SetProperty(ref _modifyPriceInSales, value); }
        
        public int OperTypeCashPurchase { get => _operTypeCashPurchase; set => SetProperty(ref _operTypeCashPurchase, value); }
        
        public int OperTypeCashSale { get => _operTypeCashSale; set => SetProperty(ref _operTypeCashSale, value); }
        
        public int OperTypeCreditPurchase { get => _operTypeCreditPurchase; set => SetProperty(ref _operTypeCreditPurchase, value); }
        
        public int OperTypeCreditSale { get => _operTypeCreditSale; set => SetProperty(ref _operTypeCreditSale, value); }
        
        public int PriceLevelDefault { get => _priceLevelDefault; set => SetProperty(ref _priceLevelDefault, value); }
        
        public decimal MaxDiscountPercent { get => _maxDiscountPercent; set => SetProperty(ref _maxDiscountPercent, value); }
        
        public int InstallmentPeriod { get => _installmentPeriod; set => SetProperty(ref _installmentPeriod, value); }
    }
}