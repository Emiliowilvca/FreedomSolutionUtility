using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SaleDto : SaleBase, ISale
    {
        public SaleAuthorizeDto SaleAuthorizeDto { get; set; }

        public IEnumerable<SaleDetailDto> SaleDetailsDtos { get; set; }

        public IEnumerable<SaleFeesDto> SaleFeesDtos { get; set; }
    }
}


