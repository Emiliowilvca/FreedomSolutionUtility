using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class WithholdingVouchersBind : BindableBase, IWithholdingVouchers
    {
        private int _id;
        private int _companyId;

        private string _code;
        private string _description;
        private int _taxPayerStatusId;
        private string _taxType;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }

        public int TaxPayerStatusId { get => _taxPayerStatusId; set => SetProperty(ref _taxPayerStatusId, value); }

        public string TaxType { get => _taxType; set => SetProperty(ref _taxType, value); }
    }
}