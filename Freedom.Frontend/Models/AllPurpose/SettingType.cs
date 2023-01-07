﻿using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class SettingType : BindableBase
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }
    }
}