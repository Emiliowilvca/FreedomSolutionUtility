using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class ProductPlusRTO : IProductPlusRTO
    {
        public int ProductId { get; set; }

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

        public string BrandName { get; set; }

        public string GroupName { get; set; }

        public string SubGroupName { get; set; }

        public string MeasureName { get; set; }

        public string PackageName { get; set; }

        public string PriorityName { get; set; }

        public string SourceName { get; set; }

        public int StockId { get; set; }

        public int ShopId { get; set; }

        public decimal StockQuantity { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }

        public int ShelvingSectorId { get; set; }

        public int Shelving { get; set; }

        public int ShelvingSide { get; set; }

        public int ShelvingColumn { get; set; }

        public int ShelvingLine { get; set; }

        public int PriceId { get; set; }

        public int MoneyId { get; set; }

        public short PriceLevel { get; set; }

        public decimal ValuePrice { get; set; }

        public short PriceQuantity { get; set; }

        public byte TypePrice { get; set; }

        public string ShopName { get; set; }

        public string MoneyName { get; set; }
    }
}