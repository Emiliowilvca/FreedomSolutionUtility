using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Frontend.Models.Bindable
{
    public class ProductHistoryBind : BindableBase, IProductHistory
    {
        private string _boxName;
        private DateTime _datePurchase;
        private long _invoiceNum;
        private string _moneyName;
        private int _operationTypeId;
        private string _operationTypeInitial;
        private string _operationTypeName;
        private decimal _price;
        private decimal _priceBox;
        private int _productId;
        private int _providerId;
        private string _providerName;
        private int _purchaseId;
        private decimal _quantity;
        private decimal _quantityBox;
        private string _shopName;

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public DateTime DatePurchase { get => _datePurchase; set => SetProperty(ref _datePurchase, value); }

        public long InvoiceNum { get => _invoiceNum; set => SetProperty(ref _invoiceNum, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public string OperationTypeInitial { get => _operationTypeInitial; set => SetProperty(ref _operationTypeInitial, value); }

        public string OperationTypeName { get => _operationTypeName; set => SetProperty(ref _operationTypeName, value); }

        public decimal Price { get => _price; set => SetProperty(ref _price, value); }

        public decimal PriceBox { get => _priceBox; set => SetProperty(ref _priceBox, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public string ProviderName { get => _providerName; set => SetProperty(ref _providerName, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public decimal Quantity { get => _quantity; set => SetProperty(ref _quantity, value); }

        public decimal QuantityBox { get => _quantityBox; set => SetProperty(ref _quantityBox, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }
    }
}