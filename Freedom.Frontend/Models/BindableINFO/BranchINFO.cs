﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class BranchINFO : BindableBase, IBranchRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
        public int CompanyId { get; set; }
    }
}