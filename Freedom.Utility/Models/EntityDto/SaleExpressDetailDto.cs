using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class SaleExpressDetailDto : SaleDetailDto, ISaleDetailJson
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}