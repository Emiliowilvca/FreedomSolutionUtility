using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class PurchaseDetailRTO : PurchaseDetailDto, IPurchaseDetailRTO
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string ExpirationStr { get; set; }

        public bool IsPopulate { get; set; }

        public string ManufactoryStr { get; set; }

        public int MoneyId { get; set; }

        public Guid RowId { get; set; }

        public decimal SubTotal { get; }

        public string UrlPrimaryImage { get; set; }

        public Guid UserId { get; set; }
    }
}