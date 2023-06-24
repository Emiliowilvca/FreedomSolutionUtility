using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class PackageINFO : BindableBase, IPackageRTO, ISelectable
    {
        private int _id;
        private string _name;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public bool IsSelected { get => _isSelected; set => _isSelected = value; }
        public int CompanyId { get; set; }
    }
}