using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.RTO;

namespace Freedom.Utility.Models.FullDto
{
    [Obsolete("ya no debo usar", true)]
    public class ProductDtoFull : ProductBase, IProduct
    {
        
        public string GroupName { get; set; }

        public string SubGroupName { get; set; }

        public string BrandName { get; set; }

        public string MeasureName { get; set; }

        public string PackageName { get; set; }

        public string PriorityName { get; set; }

        public string SourceName { get; set; }

        public IEnumerable<PriceRTO> Prices { get; set; }

        public IEnumerable<StockRTO> Stocks { get; set; }

        public IEnumerable<ApplyRTO> Applies { get; set; }

        public IEnumerable<WayAdminRTO> WayAdmins { get; set; }

        public IEnumerable<DrugRTO> Drugs { get; set; }
    }
}