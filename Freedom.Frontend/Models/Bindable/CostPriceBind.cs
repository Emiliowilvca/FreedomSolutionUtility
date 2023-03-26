using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class CostPriceBind : BindableBase
    {
        private int _id;
        private int _companyId;
        private int _productId;
        private int _moneyId;
        private string _costValue;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string CostValue { get => _costValue; set => SetProperty(ref _costValue, value); }
    }
}