﻿using Freedom.Utility.Models.BaseDTO;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class SaleExpressDto : SaleBase
    {
        public SaleAuthorizeDto SaleAuthorizeDto { get; set; }

        public IEnumerable<SaleDetailJsonDto> SaleDetailJsonDtos { get; set; }

        public IEnumerable<SaleFeesDto> SaleFeesDtos { get; set; }
    }
}