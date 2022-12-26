﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CountryINFO : BindableBase, ICountryRTO, ISelectable
    {
        private int _id;
        private string _name;
        private bool _isSelected;
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            IsSelected = false;
            Id = 0;
            Name = "";
        }
    }
}