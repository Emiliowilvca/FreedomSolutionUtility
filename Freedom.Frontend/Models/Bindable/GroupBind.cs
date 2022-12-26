using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class GroupBind : BindableBase, IGroup, ISelectable
    {
        private int _id;
        private string _name;
        private int _companyId;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            Name = "";
            CompanyId = 0;
            IsSelected = false;
        }

        public override object Clone()
        {
            GroupBind groupBind = (GroupBind)this.MemberwiseClone();
            return groupBind;
        }
    }
}