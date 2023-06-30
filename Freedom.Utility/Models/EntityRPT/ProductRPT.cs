using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceBase;

namespace Freedom.Utility.Models.EntityRPT
{
    public class ProductRPT : ProductBase, IProductBase
    {
        public GroupRTO Group { get; set; }

        public SubGroupRTO SubGroup { get; set; }

        public MeasureRTO Measure { get; set; }

        public PackageRTO Package { get; set; }

        public PriorityRTO Priority { get; set; }

        public SourceProductRTO Source { get; set; }

        public BrandRTO Brand { get; set; }

        public CostPriceRTO CostPrice { get; set; }

        public IEnumerable<ProductImageRTO> ProductImages { get; set; }

        public IEnumerable<SalePriceRTO> Prices { get; set; }

        public IEnumerable<StockRTO> Stocks { get; set; }

        public IEnumerable<ApplyRTO> Applies { get; set; }

        public IEnumerable<WayAdminRTO> WayAdmins { get; set; }

        public IEnumerable<DrugRTO> Drugs { get; set; }
    }
}