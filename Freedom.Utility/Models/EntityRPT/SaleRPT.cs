using Freedom.Utility.Models.EntityDto;
using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRPT
{
    public class SaleRPT : SaleRTO, ISaleRTO
    {
        public string CompanyAddress { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyCountry { get; set; }

        public string CompanyName { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public string CompanyState { get; set; }

        public IEnumerable<SaleDetailRTO> SaleDetails { get; set; }

        //public IEnumerable<SaleExpressDetailDto> SaleExpressDetails { get; set; }
    }
}