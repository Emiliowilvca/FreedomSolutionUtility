namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProductPlusRTO
    {
        int ProductId { get; set; }

        int BrandId { get; set; }

        int CompanyId { get; set; }

        int GroupId { get; set; }

        int MeasureId { get; set; }

        int PackageId { get; set; }

        int PriorityId { get; set; }

        int SourceId { get; set; }

        int SubgroupId { get; set; }

        string Advantage { get; set; }

        string Barcode { get; set; }

        string Benefit { get; set; }

        string Code { get; set; }

        string CodeProvider { get; set; }

        string Feature { get; set; }

        string GenericName { get; set; }

        string Name { get; set; }

        decimal ComissionSale { get; set; }

        decimal MaxDiscount { get; set; }

        decimal QuantityBox { get; set; }

        decimal StockMax { get; set; }

        decimal StockMin { get; set; }

        decimal TaxRate { get; set; }

        decimal Weight { get; set; }

        bool ActiveProduct { get; set; }

        bool AlterStock { get; set; }

        bool IsService { get; set; }

        bool PayTax { get; set; }

        bool ProCheck { get; set; }

        bool Wholesaler { get; set; }

        // names

        string BrandName { get; set; }

        string GroupName { get; set; }

        string SubGroupName { get; set; }

        string MeasureName { get; set; }

        string PackageName { get; set; }

        string PriorityName { get; set; }

        string SourceName { get; set; }

        //stock
        int StockId { get; set; }

        int ShopId { get; set; }

        decimal StockQuantity { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        int ShelvingSectorId { get; set; }

        int Shelving { get; set; }

        int ShelvingSide { get; set; }

        int ShelvingColumn { get; set; }

        int ShelvingLine { get; set; }

        string ShopName { get; set; }

        //prices

        int PriceId { get; set; }

        int MoneyId { get; set; }

        short PriceLevel { get; set; }

        decimal ValuePrice { get; set; }

        /// <summary>
        /// Price per Quantity
        /// </summary>
        short PriceQuantity { get; set; }

        byte TypePrice { get; set; }

        string MoneyName { get; set; }
    }
}