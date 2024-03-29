﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class SubGroupBind : BindableBase, ISubGroupRTO, ISelectable
    {
        private int _id;
        private string _name;
        private int _companyId;
        private int _groupId;
        private string _groupName;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int GroupId { get => _groupId; set => SetProperty(ref _groupId, value); }

        public string GroupName { get => _groupName; set => SetProperty(ref _groupName, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}