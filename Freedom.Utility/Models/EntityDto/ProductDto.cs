using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class ProductDto : ProductBase, IProduct
    {
        public ICollection<CostPriceDto> CostPrices { get; set; }

        public ICollection<SalePriceDto> SalePrices { get; set; }

        public ICollection<StockDto> Stocks { get; set; }

        public ICollection<ProductDrugDto> ProductDrugs { get; set; }

        public ICollection<ProductApplyDto> ProductApplies { get; set; }

        public ICollection<ProductWayAdminDto> ProductWayAdmins { get; set; }
    }
}