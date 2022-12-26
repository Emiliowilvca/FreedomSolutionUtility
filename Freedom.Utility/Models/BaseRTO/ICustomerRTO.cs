namespace Freedom.Utility.Models.BaseRTO
{
    public interface ICustomerRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string FullName { get; set; }

        string Address { get; set; }

        string TradeName { get; set; }

        string Ruc { get; set; }

        string Telephone { get; set; }

        string Mobile1 { get; set; }

        string City { get; set; }

        int CityId { get; set; }

        string Category { get; set; }

        int CategoryId { get; set; }

        string Branch { get; set; }

        int BranchId { get; set; }

        string Route { get; set; }

        int RouteId { get; set; }

    }
}