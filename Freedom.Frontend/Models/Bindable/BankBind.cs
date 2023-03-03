﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankBind : BindableBase, IBank
    {
        private int _id;
        private string _name;
        private string _address;
        private string _phone;
        private string _mobile;
        private string _web;
        private string _mail;
        private string _manager;
        private int _cityId;
        private int _companyId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public string Mobile { get => _mobile; set => SetProperty(ref _mobile, value); }

        public string Web { get => _web; set => SetProperty(ref _web, value); }

        public string Mail { get => _mail; set => SetProperty(ref _mail, value); }

        public string Manager { get => _manager; set => SetProperty(ref _manager, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }
    }
}