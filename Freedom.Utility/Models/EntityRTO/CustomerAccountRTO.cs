using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class CustomerAccountRTO : CustomerAccountDto, ICustomerAccountRTO
    {
        public string MoneyName { get; set; }

        public string ShopName { get; set; }

        public string EmployeeName { get; set; }

        public string CustomerFullName { get; set; }

        public string Ruc { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerCity { get; set; }
    }
}