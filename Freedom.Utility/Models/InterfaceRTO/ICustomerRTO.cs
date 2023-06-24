using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ICustomerRTO : ICustomer
    {
        string City { get; set; }

        string Category { get; set; }

        string Branch { get; set; }

        string Route { get; set; }
    }
}