using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class WithholdingVouchersBind : BindableBase, IWithholdingVouchers
    {
        private int _id;
        private int _companyId;
        private int _vourchersType;
        private string _code;
        private string _description;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int VourchersType { get => _vourchersType; set => SetProperty(ref _vourchersType, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            VourchersType = 0;
            Code = "";
            Description = "";
        }
    }
}