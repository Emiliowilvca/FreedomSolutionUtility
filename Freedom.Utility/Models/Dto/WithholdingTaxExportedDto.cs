﻿using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class WithholdingTaxExportedDto : IEntity, IWithholdingTaxExported
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int PurchaseId { get; set; }

        public int PurchaseWithHoldingTaxId { get; set; }
    }
}