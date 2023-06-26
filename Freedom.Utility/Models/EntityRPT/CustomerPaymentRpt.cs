using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRPT
{
    public class CustomerPaymentRpt : CustomerPaymentRTO, ICustomerPaymentRTO
    {
        public IEnumerable<CustomerPaymentDetailRpt> CustomerPaymentDetails { get; set; }
    }
}