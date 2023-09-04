using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRPT
{
    public class CustomerPaymentRpt : CustomerPaymentRTO, ICustomerPaymentRTO
    {
        public string CompanyAddress { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyCountry { get; set; }

        public string CompanyName { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public string CompanyState { get; set; }

        public string CompanyRuc { get; set; }

        public IEnumerable<CustomerPaymentDetailRpt> CustomerPaymentDetails { get; set; }
    }
}