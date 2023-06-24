using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class RouteRTO : RouteDto, IRouteRTO
    {
        public string ZoneName { get; set; }
    }
}