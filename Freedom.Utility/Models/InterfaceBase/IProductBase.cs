namespace Freedom.Utility.Models.InterfaceBase
{
    public interface IProductBase
    {
        int Id { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        string CodeProvider { get; set; }

        string Barcode { get; set; }

        string GenericName { get; set; }

        int CompanyId { get; set; }

        int GroupId { get; set; }

        int SubgroupId { get; set; }

        int BrandId { get; set; }

        int MeasureId { get; set; }

        int PackageId { get; set; }

        int PriorityId { get; set; }

        int SourceId { get; set; }

        decimal ComissionSale { get; set; }

        decimal MaxDiscount { get; set; }

        decimal QuantityBox { get; set; }

        decimal StockMax { get; set; }

        decimal StockMin { get; set; }

        decimal TaxRate { get; set; }

        decimal Weight { get; set; }

        bool AlterStock { get; set; }

        bool IsService { get; set; }

        bool PayTax { get; set; }

        bool ProCheck { get; set; }

        bool Wholesaler { get; set; }

        string Advantage { get; set; }

        string Feature { get; set; }

        string Benefit { get; set; }

        bool IsActive { get; set; }
    }
}