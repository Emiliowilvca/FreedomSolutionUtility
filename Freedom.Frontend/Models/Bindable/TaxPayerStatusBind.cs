using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class TaxPayerStatusBind : BindableBase, ITaxPayerStatusRTO
    {
        private int _id;
        private int _companyId;
        private string _name;
        private string _codeSET;
        private string _nameSET;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string CodeSET { get => _codeSET; set => SetProperty(ref _codeSET, value); }

        public string NameSET { get => _nameSET; set => SetProperty(ref _nameSET, value); }
    }
}