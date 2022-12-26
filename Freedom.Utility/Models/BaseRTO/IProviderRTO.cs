using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IProviderRTO: IProvider
    {
        string CityName { get; set; }

        string ProviderTypeName { get; set; }

        string PaymentTypeName { get; set; }
    }
}