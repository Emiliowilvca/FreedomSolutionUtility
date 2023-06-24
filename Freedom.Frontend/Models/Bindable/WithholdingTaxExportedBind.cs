using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class WithholdingTaxExportedBind : BindableBase, IWithholdingTaxExported
    {
        private int _id;
        private int _companyId;
        private int _purchaseId;
        private int _purchaseWithHoldingTaxId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int PurchaseWithHoldingTaxId { get => _purchaseWithHoldingTaxId; set => SetProperty(ref _purchaseWithHoldingTaxId, value); }
    }
}