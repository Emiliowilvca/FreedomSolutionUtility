using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class PriceTagBind : ProductMinBind, ISelectable
    {
        private int _quantity;
        private bool _isSelected;
        private bool _isPopulate;
        private Guid _rowId;
        private string _manufactoryStr;
        private string _expirationStr;
        private string _costEncrypt;

        public Guid RowId { get => _rowId; set => SetProperty(ref _rowId, value); }

        public int Quantity { get => _quantity; set => SetProperty(ref _quantity, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public string ManufactoryStr { get => _manufactoryStr; set => SetProperty(ref _manufactoryStr, value); }

        public string ExpirationStr { get => _expirationStr; set => SetProperty(ref _expirationStr, value); }

        public string CostEncrypt { get => _costEncrypt; set => SetProperty(ref _costEncrypt, value); }
    }
}