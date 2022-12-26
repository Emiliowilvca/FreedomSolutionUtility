using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class RouteINFO : BindableBase, IRouteRTO, ISelectable
    {
        private int _id;
        private string _name;
        private int _companyId;
        private int _zoneId;
        private string _zoneName;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ZoneId { get => _zoneId; set => SetProperty(ref _zoneId, value); }

        public string ZoneName { get => _zoneName; set => SetProperty(ref _zoneName, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}