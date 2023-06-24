using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class StateINFO : BindableBase, IStateRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;
        private string _countryName;
        private int _countryId;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string CountryName { get => _countryName; set => SetProperty(ref _countryName, value); }

        public int CountryId { get => _countryId; set => SetProperty(ref _countryId, value); }
        public int CompanyId { get; set; }
    }
}