using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class EmployeeRTO : IEmployeeRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Identity { get; set; }

        public string Phone { get; set; }

        public string JobPost { get; set; }

        public string JobSector { get; set; }

        public int JobPostId { get; set; }

        public int JobSectorId { get; set; }

        public int CityId { get; set; }
    }
}