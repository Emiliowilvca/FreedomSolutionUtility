using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class TownBind : BindableBase, ITown
    {
        private int _id;
        private string _name;
        private int _cityId;
        private int _companyId;
        private string _cityName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }
    }
}