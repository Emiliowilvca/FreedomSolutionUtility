using Freedom.Utility.Models.BaseDTO;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SaleExpressDto : SaleBase
    {
        public SaleAuthorizeDto SaleAuthorizeDto { get; set; }

        public IEnumerable<SaleExpressDetailDto> SaleExpressDetailDtos { get; set; }

        public IEnumerable<SaleFeesDto> SaleFeesDtos { get; set; }
    }
}