﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class CityBind : BindableBase, ICityRTO, ISelectable
    {
        private int _id;
        private string _name;
        private int _stateId;
        private int _companyId;
        private bool _isSelected;
        private string _stateName;
        private string _countryName;
        private int _countryId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string StateName { get => _stateName; set => SetProperty(ref _stateName, value); }

        public string CountryName { get => _countryName; set => SetProperty(ref _countryName, value); }

        public int StateId { get => _stateId; set => SetProperty(ref _stateId, value); }

        public int CountryId { get => _countryId; set => SetProperty(ref _countryId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}