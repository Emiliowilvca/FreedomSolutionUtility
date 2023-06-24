using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class SubClassOperationINFO : BindableBase, ISelectable
    {
        private int _id;
        private string _name;
        private bool _isSelected;
        private string _description;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}