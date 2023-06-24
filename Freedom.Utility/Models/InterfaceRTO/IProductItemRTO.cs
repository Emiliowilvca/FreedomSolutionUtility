namespace Freedom.Utility.Models.InterfaceRTO
{
    [Obsolete("use product full", true)]
    public interface IProductItemRTO : IProductRTO
    {
        string GroupName { get; set; }

        string SubGroupName { get; set; }

        string BrandName { get; set; }
    }
}