using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class WithholdingTaxExportedDto : IEntity, IWithholdingTaxExported
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int PurchaseId { get; set; }

        public int WithholdingTaxId { get; set; }
    }
}