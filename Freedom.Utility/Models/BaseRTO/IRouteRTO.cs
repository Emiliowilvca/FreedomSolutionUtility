namespace Freedom.Utility.Models.BaseRTO
{
    public interface IRouteRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int ZoneId { get; set; }

        string ZoneName { get; set; }
    }
}