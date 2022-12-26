using Freedom.Utility.Models.Dto;
using System;

namespace Freedom.Utility.Models.FullDto
{
    [Serializable]
    public class EmployeeDtoFull : EmployeeDto
    {
        public string CityName { get; set; }

        public string JobPostName { get; set; }

        public string JobSectorName { get; set; }
    }
}