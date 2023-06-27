using Freedom.Frontend.Models.BaseBindableEntity;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class ProductItemBind : ProductItemBase, IProductItem
    {
        private int _stockInput;

        public int StockInput { get => _stockInput; set => SetProperty(ref _stockInput, value); }

    }
}