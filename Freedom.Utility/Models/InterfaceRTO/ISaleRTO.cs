using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ISaleRTO : ISale
    {
        int DecimalPlaces { get; set; }
        string AccountName { get; set; }
        string AuthorizedStaff { get; set; }
        string AuthorizingOfficer { get; set; }
        string BoxName { get; set; }
        string CustomerAccount { get; set; }
        string CustomerAddress { get; set; }
        string CustomerName { get; set; }
        string CustomerPhone { get; set; }
        string CustomerRuc { get; set; }
        string EmployeeName { get; set; }
        string MoneyName { get; set; }
        string OperationTypeName { get; set; }
        string ShopName { get; set; }
        string UserName { get; set; }
    }
}