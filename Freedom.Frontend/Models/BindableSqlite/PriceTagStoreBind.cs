using Freedom.Frontend.Models.BaseEntitySqlite;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.BindableSqlite
{
    public class PriceTagStoreBind : BindableBase, IPriceTagStore
    {
        private Guid _id;
        private int _companyId;
        private int _shopId;
        private Guid _userId;
        private DateTime _storeDate;
        private string _userName;
        private string _companyName;
        private string _shopName;
        private string _jsonModel;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }
        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }
        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }
        public DateTime StoreDate { get => _storeDate; set => SetProperty(ref _storeDate, value); }
        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }
        public string CompanyName { get => _companyName; set => SetProperty(ref _companyName, value); }
        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }
        public string JsonModel { get => _jsonModel; set => SetProperty(ref _jsonModel, value); }
    }
}