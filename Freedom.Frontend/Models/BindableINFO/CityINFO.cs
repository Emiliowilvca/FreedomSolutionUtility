using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CityINFO : BindableBase, ICityRTO, ISelectable
    {
        private int _id;
        private string _name;
        private string _stateName;
        private string _countryName;
        private bool _isSelected;
        private int _countryId;
        private int _stateId;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string StateName { get => _stateName; set => SetProperty(ref _stateName, value); }

        public string CountryName { get => _countryName; set => SetProperty(ref _countryName, value); }

        public int CountryId { get => _countryId; set => SetProperty(ref _countryId, value); }

        public int StateId { get => _stateId; set => SetProperty(ref _stateId, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            IsSelected = false;
            Name = "";
            StateName = "";
            CountryName = "";
            CountryId = 0;
            StateId = 0;
        }
    }
}