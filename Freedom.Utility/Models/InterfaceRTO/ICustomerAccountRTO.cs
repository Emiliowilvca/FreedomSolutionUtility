using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ICustomerAccountRTO : ICustomerAccount
    {
        string CustomerFullName { get; set; }

        string Ruc { get; set; }

        string MoneyName { get; set; }

        string ShopName { get; set; }

        string EmployeeName { get; set; }

        string CustomerPhone { get; set; }

        string CustomerCity { get; set; }
    }
}