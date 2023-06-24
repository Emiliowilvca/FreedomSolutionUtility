using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IProviderRTO: IProvider
    {
        string CityName { get; set; }

        string ProviderTypeName { get; set; }

        string PaymentTypeName { get; set; }
    }
}