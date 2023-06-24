using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class CustomerDebtRTO : CustomerAccountRTO, ICustomerDebtRTO
    {
        public IEnumerable<CustomerDebtDetailRTO> CustomerDebtDetailRTO { get; set; }
    }
}