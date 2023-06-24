using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class CustomerRTO : CustomerDto, ICustomerRTO
    {
        public string City { get; set; }

        public string Category { get; set; }

        public string Branch { get; set; }

        public string Route { get; set; }
    }
}