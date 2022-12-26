using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class RouteRTO : IRouteRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }

        public int ZoneId { get; set; }

        public string ZoneName { get; set; }
    }
}