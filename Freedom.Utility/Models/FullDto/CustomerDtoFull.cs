using Freedom.Utility.Models.Dto;

namespace Freedom.Utility.Models.FullDto
{
    public class CustomerDtoFull : CustomerDto
    {
        public string CityName { get; set; }

        public string BranchName { get; set; }

        public string RouteName { get; set; }

        public string CategoryName { get; set; }
    }
}