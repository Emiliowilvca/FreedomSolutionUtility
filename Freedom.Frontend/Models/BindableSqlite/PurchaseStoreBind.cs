using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.BindableSqlite
{
    public class PurchaseStoreBind : BindableBase
    {
        private Guid _id;
        private Guid _userId;
        private DateTime _purchaseDate;
        private string _ruc;
        private string _providerName;
        private int _boxId;
        private int _moneyId;
        private string _boxName;
        private decimal _total;
        private string _moneyName;
        private string _jsonModel;
        private string _jsonDetails;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public DateTime PurchaseDate { get => _purchaseDate; set => SetProperty(ref _purchaseDate, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public string ProviderName { get => _providerName; set => SetProperty(ref _providerName, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal Total { get => _total; set => SetProperty(ref _total, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string JsonModel { get => _jsonModel; set => SetProperty(ref _jsonModel, value); }

        public string JsonDetails { get => _jsonDetails; set => SetProperty(ref _jsonDetails, value); }
    }
}