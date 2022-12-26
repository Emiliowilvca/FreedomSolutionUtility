using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class ShopRuleBind : BindableBase
    {
        private int _id;
        private int _companyId;
        private int _shopId;
        private string _decimalInStock;
        private string _encryptPriceKey;
        private string _interestRateMonthly;
        private bool _forceSaleIfStockIsZero;
        private bool _grantDiscounts;
        private string _maxItemInSale;
        private bool _modifyPriceInSales;
        private int _operTypeCashPurchase;
        private int _operTypeCashSale;
        private int _operTypeCreditPurchase;
        private int _operTypeCreditSale;
        private string _priceLevelDefault;
        private string _maxDiscountPercent;
        private int _customerId;
        private string _operTypeCashPurchaseName;
        private string _operTypeCreditPurchaseName;
        private string _operTypeCashSaleName;
        private string _operTypeCreditSaleName;
        private string _customerName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public string DecimalInStock { get => _decimalInStock; set => SetProperty(ref _decimalInStock, value); }

        public string EncryptPriceKey { get => _encryptPriceKey; set => SetProperty(ref _encryptPriceKey, value); }

        public string InterestRateMonthly { get => _interestRateMonthly; set => SetProperty(ref _interestRateMonthly, value); }

        public bool ForceSaleIfStockIsZero { get => _forceSaleIfStockIsZero; set => SetProperty(ref _forceSaleIfStockIsZero, value); }

        public bool GrantDiscounts { get => _grantDiscounts; set => SetProperty(ref _grantDiscounts, value); }

        public string MaxItemInSale { get => _maxItemInSale; set => SetProperty(ref _maxItemInSale, value); }

        public bool ModifyPriceInSales { get => _modifyPriceInSales; set => SetProperty(ref _modifyPriceInSales, value); }

        public int OperTypeCashPurchase { get => _operTypeCashPurchase; set => SetProperty(ref _operTypeCashPurchase, value); }

        public int OperTypeCashSale { get => _operTypeCashSale; set => SetProperty(ref _operTypeCashSale, value); }

        public int OperTypeCreditPurchase { get => _operTypeCreditPurchase; set => SetProperty(ref _operTypeCreditPurchase, value); }

        public int OperTypeCreditSale { get => _operTypeCreditSale; set => SetProperty(ref _operTypeCreditSale, value); }

        public string PriceLevelDefault { get => _priceLevelDefault; set => SetProperty(ref _priceLevelDefault, value); }

        public string MaxDiscountPercent { get => _maxDiscountPercent; set => SetProperty(ref _maxDiscountPercent, value); }

        public int CustomerId { get => _customerId; set => SetProperty(ref _customerId, value); }

        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }

        public string OperTypeCashPurchaseName { get => _operTypeCashPurchaseName; set => _operTypeCashPurchaseName = value; }

        public string OperTypeCreditPurchaseName { get => _operTypeCreditPurchaseName; set => _operTypeCreditPurchaseName = value; }

        public string OperTypeCashSaleName { get => _operTypeCashSaleName; set => _operTypeCashSaleName = value; }

        public string OperTypeCreditSaleName { get => _operTypeCreditSaleName; set => _operTypeCreditSaleName = value; }
      
        
        
       

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            ShopId = 0;
            DecimalInStock = "";
            EncryptPriceKey = "";
            InterestRateMonthly = "";
            ForceSaleIfStockIsZero = false;
            GrantDiscounts = false;
            MaxItemInSale = "";
            ModifyPriceInSales = false;
            OperTypeCashPurchase = 0;
            OperTypeCashPurchaseName = "";
            OperTypeCashSale = 0;
            OperTypeCashSaleName = "";
            OperTypeCreditPurchase = 0;
            OperTypeCreditPurchaseName = "";
            OperTypeCreditSale = 0;
            OperTypeCreditSaleName = "";
            PriceLevelDefault = "";
            CustomerName = "";
            MaxDiscountPercent = "";
            CustomerId = 0;
        }
    }
}