using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class SubGroupBind : BindableBase, ISubGroup
    {
        private int _id;
        private string _name;
        private int _companyId;
        private int _groupId;
        private string _groupName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int GroupId { get => _groupId; set => SetProperty(ref _groupId, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }
    }
}