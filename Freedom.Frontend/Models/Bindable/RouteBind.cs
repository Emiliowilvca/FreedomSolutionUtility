﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class RouteBind : BindableBase, IRoute
    {
        private int _id;
        private string _name;
        private int _companyId;
        private int _zoneId;
        private string _zoneName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ZoneId { get => _zoneId; set => SetProperty(ref _zoneId, value); }

        public string ZoneName { get => _zoneName; set => SetProperty(ref _zoneName, value); }
    }
}