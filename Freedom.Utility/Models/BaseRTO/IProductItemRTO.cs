namespace Freedom.Utility.Models.BaseRTO
{
    [Obsolete("use product full", true)]
    public interface IProductItemRTO : IProductRTO
    {
        string CodeProvider { get; set; }

        string Barcode { get; set; }

        string GroupName { get; set; }

        string SubGroupName { get; set; }

        string BrandName { get; set; }

        decimal QuantityBox { get; set; }

        decimal Weight { get; set; }

        //money
        string MoneyName { get; set; }
    }
}