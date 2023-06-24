using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class EmployeeRTO : EmployeeDto, IEmployeeRTO
    {
        public string City { get; set; }

        public string JobPost { get; set; }

        public string JobSector { get; set; }
    }
}