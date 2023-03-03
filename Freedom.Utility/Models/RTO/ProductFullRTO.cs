using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class ProductFullRTO : ProductRTO, IProductFullRTO
    {
        public bool ActiveProduct { get; set; }

        public bool Wholesaler { get; set; }

        public byte TypePrice { get; set; }

        public DateTime Expiration { get; set; }

        public DateTime Manufactory { get; set; }

        public decimal ComissionSale { get; set; }

        public decimal QuantityBox { get; set; }

        public decimal StockMax { get; set; }

        public decimal StockMin { get; set; }

        public decimal Weight { get; set; }

        public int BrandId { get; set; }

        public int CompanyId { get; set; }

        public int GroupId { get; set; }

        public int MeasureId { get; set; }

        public int PackageId { get; set; }

        public int PriorityId { get; set; }

        public int Shelving { get; set; }

        public int ShelvingColumn { get; set; }

        public int ShelvingLine { get; set; }

        public int ShelvingSectorId { get; set; }

        public int ShelvingSide { get; set; }

        public int SourceId { get; set; }

        public int StockId { get; set; }

        public int SubgroupId { get; set; }

        public short PriceLevel { get; set; }

        public short PriceQuantity { get; set; }

        public string Advantage { get; set; }

        public string Barcode { get; set; }

        public string Benefit { get; set; }

        public string BrandName { get; set; }

        public string CodeProvider { get; set; }

        public string Feature { get; set; }

        public string GenericName { get; set; }

        public string GroupName { get; set; }

        public string Lote { get; set; }

        public string MeasureName { get; set; }

        public string MoneyName { get; set; }

        public string PackageName { get; set; }

        public string PriorityName { get; set; }

        public string SourceName { get; set; }

        public string SubGroupName { get; set; }
    }
}