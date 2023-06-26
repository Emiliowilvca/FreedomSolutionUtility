using Freedom.Utility.Models.EntityBase;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class CustomerPaymentDto : CustomerPaymentBase, ICustomerPayment
    {
        public IEnumerable<CustomerPaymentDetailDto> CustomerPaymentDetails { get; set; }

        public IEnumerable<CustomerPaymentDocDto> CustomerPaymentDocs { get; set; }
    }
}