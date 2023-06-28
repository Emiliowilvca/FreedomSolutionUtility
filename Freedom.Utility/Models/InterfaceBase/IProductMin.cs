namespace Freedom.Utility.Models.InterfaceBase
{
    public interface IProductMin : IProductItem
    {
        string CodeProvider { get; set; }

        string Barcode { get; set; }

        string MeasureName { get; set; }

        string GroupName { get; set; }

        string SubGroupName { get; set; }

        string BrandName { get; set; }

        decimal Weight { get; set; }

        string MoneySymbol { get; set; }

        string MoneyName { get; set; }
    }
}