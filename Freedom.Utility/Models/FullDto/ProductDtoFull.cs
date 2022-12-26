using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.Dto;
using Freedom.Utility.Models.RTO;
using System.Collections.Generic;

namespace Freedom.Utility.Models.FullDto
{
    public class ProductDtoFull : IProduct
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public int CompanyId { get; set; }

        public int GroupId { get; set; }

        public int MeasureId { get; set; }

        public int PackageId { get; set; }

        public int PriorityId { get; set; }

        public int SourceId { get; set; }

        public int SubgroupId { get; set; }

        public string Advantage { get; set; }

        public string Barcode { get; set; }

        public string Benefit { get; set; }

        public string Code { get; set; }

        public string CodeProvider { get; set; }

        public string Feature { get; set; }

        public string GenericName { get; set; }

        public string Name { get; set; }

        public decimal ComissionSale { get; set; }

        public decimal MaxDiscount { get; set; }

        public decimal QuantityBox { get; set; }

        public decimal StockMax { get; set; }

        public decimal StockMin { get; set; }

        public decimal TaxRate { get; set; }

        public decimal Weight { get; set; }

        public bool ActiveProduct { get; set; }

        public bool AlterStock { get; set; }

        public bool IsService { get; set; }

        public bool PayTax { get; set; }

        public bool ProCheck { get; set; }

        public bool Wholesaler { get; set; }

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