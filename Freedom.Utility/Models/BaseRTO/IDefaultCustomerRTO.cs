using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IDefaultCustomerRTO : IDefaultCustomer
    {
        string CustomerAccountName { get; set; }

        string CustomerName { get; set; }

        string PersonName { get; set; }

        string MoneyName { get; set; }
    }
}