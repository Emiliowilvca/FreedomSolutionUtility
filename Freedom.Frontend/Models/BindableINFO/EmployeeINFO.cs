using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

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
    }
}