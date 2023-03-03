using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class SubGroupINFO : BindableBase, ISubGroupRTO, ISelectable
    {
        private int _id;
        private string _name;
        private bool _isSelected;
        private int _groupId;
        private string _groupName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int GroupId { get => _groupId; set => SetProperty(ref _groupId, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}