﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class JobSectorBind : BindableBase, IJobSector
    {
        private int _id;
        private int _companyId;
        private string _name;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            Name = "";
        }

        public override object Clone()
        {
            JobSectorBind jobSectorBind = (JobSectorBind)this.MemberwiseClone();
            return jobSectorBind;
        }
    }
}