using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class WithholdingTaxExportedINFO : BindableBase, IWithholdingTaxExportedRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private int _companyId;
        private int _purchaseId;
        private int _withholdingTaxId;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int PurchaseId { get => _purchaseId; set => SetProperty(ref _purchaseId, value); }

        public int WithholdingTaxId { get => _withholdingTaxId; set => SetProperty(ref _withholdingTaxId, value); }
    }
}