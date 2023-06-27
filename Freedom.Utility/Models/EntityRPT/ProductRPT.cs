using Freedom.Utility.Models.EntityRTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRPT
{
    public class ProductRPT : ProductRTO, IProductRTO
    {
        public IEnumerable<SalePriceRTO> Prices { get; set; }

        public IEnumerable<StockRTO> Stocks { get; set; }

        public IEnumerable<ApplyRTO> Applies { get; set; }

        public IEnumerable<WayAdminRTO> WayAdmins { get; set; }

        public IEnumerable<DrugRTO> Drugs { get; set; }
    }
}