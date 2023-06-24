using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IRouteRTO : IRoute
    {
        string ZoneName { get; set; }
    }
}