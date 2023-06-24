using Freedom.Utility.Models.BaseDTO;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SaleDto : SaleBase
    {
        public SaleAuthorizeDto SaleAuthorizeDto { get; set; }

        public IEnumerable<SaleDetailDto> SaleDetailsDtos { get; set; }

        public IEnumerable<SaleFeesDto> SaleFeesDtos { get; set; }
    }
}