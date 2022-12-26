using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Bindable;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class ApplyBind : BindableBase, IApply
    {
        private int _id;
        private string _name;
        private int _companyId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            Name = "";
            CompanyId = 0;
        }
    }
}