using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class TownINFO : BindableBase, ITownRTO, ISelectable
    {
        private int _id;
        private string _name;
        private bool _isSelected;
        private int _cityId;
        private string _cityName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public string CityName { get => _cityName; set => SetProperty(ref _cityName, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            Name = "";
            IsSelected = false;
        }
    }
}