using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class JobPostBind : BindableBase, IJobPost
    {
        private int _id;
        private int _companyId;
        private string _name;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }
    }
}