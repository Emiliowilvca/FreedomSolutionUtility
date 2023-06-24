using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CustomerINFO : BindableBase, ICustomerRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _fullName;
        private string _address;
        private string _tradeName;
        private string _ruc;
        private string _telephone;
        private string _mobile1;
        private string _city;
        private int _cityId;
        private string _category;
        private int _categoryId;
        private string _branch;
        private int _branchId;
        private string _route;
        private int _routeId;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string FullName { get => _fullName; set => SetProperty(ref _fullName, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string TradeName { get => _tradeName; set => SetProperty(ref _tradeName, value); }

        public string Ruc { get => _ruc; set => SetProperty(ref _ruc, value); }

        public string Telephone { get => _telephone; set => SetProperty(ref _telephone, value); }

        public string Mobile1 { get => _mobile1; set => SetProperty(ref _mobile1, value); }

        public string City { get => _city; set => SetProperty(ref _city, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public string Category { get => _category; set => SetProperty(ref _category, value); }

        public int CategoryId { get => _categoryId; set => SetProperty(ref _categoryId, value); }

        public string Branch { get => _branch; set => SetProperty(ref _branch, value); }

        public int BranchId { get => _branchId; set => SetProperty(ref _branchId, value); }

        public string Route { get => _route; set => SetProperty(ref _route, value); }

        public int RouteId { get => _routeId; set => SetProperty(ref _routeId, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
        public string Mobile2 { get; set; }
        public string WorkPlace { get; set; }
        public string Partner { get; set; }
        public int PartnerCI { get; set; }
        public DateTime ResidenceDate { get; set; }
        public bool OwnHouse { get; set; }
        public bool SendMoneyColletor { get; set; }
        public bool LendProducts { get; set; }
        public bool Credit { get; set; }
        public string Workphone { get; set; }
        public DateTime EmployementDate { get; set; }
        public string Email { get; set; }
        public string Goods { get; set; }
        public DateTime DateAdmin { get; set; }
        public DateTime BirthDate { get; set; }
        public byte Children { get; set; }
        public byte Gender { get; set; }
        public byte PriceLevel { get; set; }
        public decimal MaxDiscount { get; set; }
        public string Note { get; set; }
    }
}