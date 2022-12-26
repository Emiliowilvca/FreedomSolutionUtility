using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class WithholdingVouchersINFO : BindableBase, IWithholdingVouchersRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private int _companyId;
        private int _vourchersType;
        private string _code;
        private string _description;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int VourchersType { get => _vourchersType; set => SetProperty(ref _vourchersType, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }
    }
}