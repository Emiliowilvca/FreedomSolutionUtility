﻿using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class CustomerBind : BindableBase, ICustomerRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _fullName;
        private string _address;
        private string _tradeName;
        private string _ruc;
        private string _telephone;
        private string _mobile1;
        private string _mobile2;
        private int _cityId;
        private int _categoryId;
        private int _branchId;
        private int _routeId;
        private string _workPlace;
        private string _partner;
        private int _partnerCI;
        private DateTime _residenceDate;
        private bool _ownHouse;
        private bool _sendMoneyColletor;
        private bool _lendProducts;
        private bool _credit;
        private string _workphone;
        private DateTime _employementDate;
        private string _email;
        private string _goods;
        private DateTime _dateAdmin;
        private DateTime _birthDate;
        private byte _children;
        private byte _gender;
        private byte _priceLevel;
        private decimal _maxDiscount;
        private string _note;
        private string _city;
        private string _category;
        private string _branch;
        private string _route;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string FullName { get => _fullName; set => SetProperty(ref _fullName, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string TradeName { get => _tradeName; set => SetProperty(ref _tradeName, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public string Telephone { get => _telephone; set => SetProperty(ref _telephone, value); }

        public string Mobile1 { get => _mobile1; set => SetProperty(ref _mobile1, value); }

        public string Mobile2 { get => _mobile2; set => SetProperty(ref _mobile2, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public int CategoryId { get => _categoryId; set => SetProperty(ref _categoryId, value); }

        public int BranchId { get => _branchId; set => SetProperty(ref _branchId, value); }

        public int RouteId { get => _routeId; set => SetProperty(ref _routeId, value); }

        public string WorkPlace { get => _workPlace; set => SetProperty(ref _workPlace, value); }

        public string Partner { get => _partner; set => SetProperty(ref _partner, value); }

        public int PartnerCI { get => _partnerCI; set => SetProperty(ref _partnerCI, value); }

        public DateTime ResidenceDate { get => _residenceDate; set => SetProperty(ref _residenceDate, value); }

        public bool OwnHouse { get => _ownHouse; set => SetProperty(ref _ownHouse, value); }

        public bool SendMoneyColletor { get => _sendMoneyColletor; set => SetProperty(ref _sendMoneyColletor, value); }

        public bool LendProducts { get => _lendProducts; set => SetProperty(ref _lendProducts, value); }

        public bool Credit { get => _credit; set => SetProperty(ref _credit, value); }

        public string Workphone { get => _workphone; set => SetProperty(ref _workphone, value); }

        public DateTime EmployementDate { get => _employementDate; set => SetProperty(ref _employementDate, value); }

        public string Email { get => _email; set => SetProperty(ref _email, value); }

        public string Goods { get => _goods; set => SetProperty(ref _goods, value); }

        public DateTime DateAdmin { get => _dateAdmin; set => SetProperty(ref _dateAdmin, value); }

        public DateTime BirthDate { get => _birthDate; set => SetProperty(ref _birthDate, value); }

        public byte Children { get => _children; set => SetProperty(ref _children, value); }

        public byte Gender { get => _gender; set => SetProperty(ref _gender, value); }

        public byte PriceLevel { get => _priceLevel; set => SetProperty(ref _priceLevel, value); }

        public decimal MaxDiscount { get => _maxDiscount; set => SetProperty(ref _maxDiscount, value); }

        public string Note { get => _note; set => SetProperty(ref _note, value); }

        public string City { get => _city; set => SetProperty(ref _city, value); }

        public string Category { get => _category; set => SetProperty(ref _category, value); }

        public string Branch { get => _branch; set => SetProperty(ref _branch, value); }

        public string Route { get => _route; set => SetProperty(ref _route, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}