using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class WithholdingTaxExportedBind : BindableBase, IWithholdingTaxExported
    {
        private int _id;
        private int _companyId;
        private int _purchaseId;
        private int _withholdingTaxId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int WithholdingTaxId { get => _withholdingTaxId; set => SetProperty(ref _withholdingTaxId, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            PurchaseId = 0;
            WithholdingTaxId = 0;
        }
    }
}