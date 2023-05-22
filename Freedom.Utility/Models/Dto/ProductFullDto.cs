using Freedom.Utility.Models.BaseDTO;

namespace Freedom.Utility.Models.Dto
{
    [Obsolete("Deprecate use productFull",true)]
    public class ProductFullDto : ProductBase, IProductFullDto
    {
        public string SubGroupName { get; set; }

        public string MeasureName { get; set; }

        public string PackageName { get; set; }

        public string PriorityName { get; set; }

        public string SourceName { get; set; }

        public string BrandName { get; set; }

        public string GroupName { get; set; }

        public int ShopId { get; set; }

        public int SalePriceId { get; set; }

        public int CostPriceId { get; set; }

        public decimal Quantity { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }

        public int SectorId { get; set; }

        public int Shelving { get; set; }

        public int Side { get; set; }

        public int Column { get; set; }

        public int Line { get; set; }

        public int MoneyId { get; set; }

        public decimal CostPrice { get; set; }

        public int PriceLevel { get; set; }

        public int StockId { get; set; }

        public decimal SalePrice { get; set; }

        public int QuantityPrice { get; set; }

        public string UrlPrimaryImage { get; set; }

        public string UrlSecondaryImage { get; set; }

        public IEnumerable<DrugDto> Drugs { get; set; }

        public IEnumerable<ApplyDto> Applies { get; set; }

        public IEnumerable<WayAdminDto> WayAdmins { get; set; }
    }
}