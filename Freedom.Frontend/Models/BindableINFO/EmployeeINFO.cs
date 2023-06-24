using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class EmployeeINFO : BindableBase, IEmployeeRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;
        private string _address;
        private string _city;
        private string _identity;
        private string _phone;
        private string _jobPost;
        private string _jobSector;
        private int _jobPostId;
        private int _jobSectorId;
        private int _cityId;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string City { get => _city; set => SetProperty(ref _city, value); }

        public string Identity { get => _identity; set => SetProperty(ref _identity, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public string JobPost { get => _jobPost; set => SetProperty(ref _jobPost, value); }

        public string JobSector { get => _jobSector; set => SetProperty(ref _jobSector, value); }

        public int JobPostId { get => _jobPostId; set => SetProperty(ref _jobPostId, value); }

        public int JobSectorId { get => _jobSectorId; set => SetProperty(ref _jobSectorId, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }
        public int CompanyId { get; set; }
        public string Barcode { get; set; }
        public string PhoneMobile { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public decimal CommissionSales { get; set; }
        public decimal CommissionCollection { get; set; }
        public bool IsCommissionAgent { get; set; }
        public DateTime BirtDate { get; set; }
        public string PlaceBirt { get; set; }
        public string Sex { get; set; }
        public DateTime WorkStarDate { get; set; }
        public int ChildCount { get; set; }
        public string CivilStatus { get; set; }
        public string Profession { get; set; }
        public bool IpsEmployer { get; set; }
        public bool IpsWorked { get; set; }
        public bool ActiveWorked { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BloodType { get; set; }
        public string Nick { get; set; }
        public string PassportNum { get; set; }
        public string SpouceCI { get; set; }
        public string SpouceName { get; set; }
        public string DrivingLicenceNum { get; set; }
        public string EmergencyContact1 { get; set; }
        public string EmergencyContact2 { get; set; }
        public bool Supervisor { get; set; }
        public string Obs { get; set; }
    }
}