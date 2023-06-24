using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IBankRTO : IBank
    {
        string City { get; set; }
    }
}