using Freedom.Utility.Models.EntityBase;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class PurchaseDto : PurchaseBase, IPurchase
    {
        public ICollection<PurchaseDetailDto> PurchaseDetails { get; set; }

        public ICollection<PurchaseInstallmentDto> PurchaseInstallments { get; set; }
    }
}