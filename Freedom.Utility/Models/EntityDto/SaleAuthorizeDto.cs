using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SaleAuthorizeDto : ISaleAuthorize
    {
        public int Id { get; set; }

        public int CompanyID { get; set; }

        public int SaleId { get; set; }

        public int AuthorizingOfficerId { get; set; }

        public int AuthorizedStaffId { get; set; }
    }
}