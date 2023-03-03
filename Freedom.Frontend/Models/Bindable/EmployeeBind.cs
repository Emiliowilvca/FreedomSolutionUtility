using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class EmployeeBind : BindableBase, IEmployee, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _name;
        private string _address;
        private string _barcode;
        private string _phone;
        private string _identity;
        private int _jobSectorId;
        private int _jobPostId;
        private int _cityId;
        private string _phoneMobile;
        private string _eMail;
        private decimal _salary;
        private decimal _commissionSales;
        private decimal _commissionCollection;
        private DateTime _birtDate;
        private string _placeBirt;
        private string _sex;
        private DateTime _workStarDate;
        private int _childCount;
        private string _civilStatus;
        private string _profession;
        private bool _ipsEmployer;
        private bool _ipsWorked;
        private bool _activeWorked;
        private string _fatherName;
        private string _motherName;
        private string _bloodType;
        private string _nick;
        private string _passportNum;
        private string _spouceCI;
        private string _spouceName;
        private string _drivingLicenceNum;
        private string _emergencyContact1;
        private string _emergencyContact2;
        private bool _supervisor;
        private string _obs;
        private bool _isSelected;
        private bool _isCommissionAgent;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public string Address { get => _address; set => SetProperty(ref _address, value); }

        public string Barcode { get => _barcode; set => SetProperty(ref _barcode, value); }

        public string Phone { get => _phone; set => SetProperty(ref _phone, value); }

        public string Identity { get => _identity; set => SetProperty(ref _identity, value); }

        public int JobSectorId { get => _jobSectorId; set => SetProperty(ref _jobSectorId, value); }

        public int JobPostId { get => _jobPostId; set => SetProperty(ref _jobPostId, value); }

        public int CityId { get => _cityId; set => SetProperty(ref _cityId, value); }

        public string PhoneMobile { get => _phoneMobile; set => SetProperty(ref _phoneMobile, value); }

        public string EMail { get => _eMail; set => SetProperty(ref _eMail, value); }

        public decimal Salary { get => _salary; set => SetProperty(ref _salary, value); }

        public decimal CommissionSales { get => _commissionSales; set => SetProperty(ref _commissionSales, value); }

        public decimal CommissionCollection { get => _commissionCollection; set => SetProperty(ref _commissionCollection, value); }

        public DateTime BirtDate { get => _birtDate; set => SetProperty(ref _birtDate, value); }

        public string PlaceBirt { get => _placeBirt; set => SetProperty(ref _placeBirt, value); }

        public string Sex { get => _sex; set => SetProperty(ref _sex, value); }

        public DateTime WorkStarDate { get => _workStarDate; set => SetProperty(ref _workStarDate, value); }

        public int ChildCount { get => _childCount; set => SetProperty(ref _childCount, value); }

        public string CivilStatus { get => _civilStatus; set => SetProperty(ref _civilStatus, value); }

        public string Profession { get => _profession; set => SetProperty(ref _profession, value); }

        public bool IpsEmployer { get => _ipsEmployer; set => SetProperty(ref _ipsEmployer, value); }

        public bool IpsWorked { get => _ipsWorked; set => SetProperty(ref _ipsWorked, value); }

        public bool ActiveWorked { get => _activeWorked; set => SetProperty(ref _activeWorked, value); }

        public string FatherName { get => _fatherName; set => SetProperty(ref _fatherName, value); }

        public string MotherName { get => _motherName; set => SetProperty(ref _motherName, value); }

        public string BloodType { get => _bloodType; set => SetProperty(ref _bloodType, value); }

        public string Nick { get => _nick; set => SetProperty(ref _nick, value); }

        public string PassportNum { get => _passportNum; set => SetProperty(ref _passportNum, value); }

        public string SpouceCI { get => _spouceCI; set => SetProperty(ref _spouceCI, value); }

        public string SpouceName { get => _spouceName; set => SetProperty(ref _spouceName, value); }

        public string DrivingLicenceNum { get => _drivingLicenceNum; set => SetProperty(ref _drivingLicenceNum, value); }

        public string EmergencyContact1 { get => _emergencyContact1; set => SetProperty(ref _emergencyContact1, value); }

        public string EmergencyContact2 { get => _emergencyContact2; set => SetProperty(ref _emergencyContact2, value); }

        public bool Supervisor { get => _supervisor; set => SetProperty(ref _supervisor, value); }

        public string Obs { get => _obs; set => SetProperty(ref _obs, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public bool IsCommissionAgent { get => _isCommissionAgent; set => SetProperty(ref _isCommissionAgent, value); }
    }
}