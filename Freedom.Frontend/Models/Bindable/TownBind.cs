using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class TownBind : BindableBase, ITownRTO, ISelectable
    {
        private int _id;
        private string _name;
        private int _cityId;
        private int _companyId;
        private string _cityName;
        private int _stateId;
        private string _stateName;
        private int _countryId;
        private string _countryName;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }

        public int StateId { get => _stateId; set => SetProperty(ref _stateId, value); }

        public string StateName { get => _stateName; set => SetProperty(ref _stateName, value); }

        public int CountryId { get => _countryId; set => SetProperty(ref _countryId, value); }

        public string CountryName { get => _countryName; set => SetProperty(ref _countryName, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}