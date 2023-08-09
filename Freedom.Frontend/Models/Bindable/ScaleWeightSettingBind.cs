using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{

    /// <summary>
    /// Configuracion de Balanza con Codigo de barras
    /// </summary>
    public class ScaleWeightSettingBind : BindableBase, IScaleWeightSettingRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _shopId;
        private int _measureId;
        private int _flagValue;
        private int _flagStartIndex;
        private int _flagLength;
        private int _codeStartIndex;
        private int _codeLength;
        private int _weightStartIndex;
        private int _weightLength;
        private decimal _weightConverter;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int MeasureId { get => _measureId; set => SetProperty(ref _measureId, value); }

        public int FlagValue { get => _flagValue; set => SetProperty(ref _flagValue, value); }

        public int FlagStartIndex { get => _flagStartIndex; set => SetProperty(ref _flagStartIndex, value); }

        public int FlagLength { get => _flagLength; set => SetProperty(ref _flagLength, value); }

        public int CodeStartIndex { get => _codeStartIndex; set => SetProperty(ref _codeStartIndex, value); }

        public int CodeLength { get => _codeLength; set => SetProperty(ref _codeLength, value); }

        public int WeightStartIndex { get => _weightStartIndex; set => SetProperty(ref _weightStartIndex, value); }

        public int WeightLength { get => _weightLength; set => SetProperty(ref _weightLength, value); }

        public decimal WeightConverter { get => _weightConverter; set => SetProperty(ref _weightConverter, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}