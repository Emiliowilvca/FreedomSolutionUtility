using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IPurchaseDetailRTO : IPurchaseDetail
    {
        string Code { get; set; }

        string Description { get; set; }

        string ExpirationStr { get; set; }

        bool IsPopulate { get; set; }

        string ManufactoryStr { get; set; }

        int MoneyId { get; set; }

        Guid RowId { get; set; }

        decimal SubTotal { get; }

        string UrlPrimaryImage { get; set; }

        Guid UserId { get; set; }
    }
}