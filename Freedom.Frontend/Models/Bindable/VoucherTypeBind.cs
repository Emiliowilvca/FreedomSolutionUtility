using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class VoucherTypeBind : BindableBase, IVourcherType
    {
        private int _id;
        private int _companyId;
        private string _name;
        private string _nameSET;
        private string _codeSET;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string NameSET { get => _nameSET; set => SetProperty(ref _nameSET, value); }

        public string CodeSET { get => _codeSET; set => SetProperty(ref _codeSET, value); }
    }
}