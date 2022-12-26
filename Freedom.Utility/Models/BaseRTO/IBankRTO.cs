namespace Freedom.Utility.Models.BaseRTO
{
    public interface IBankRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        string Mobile { get; set; }

        string Web { get; set; }

        string Mail { get; set; }

        string Manager { get; set; }

        int CityId { get; set; }

        int CompanyId { get; set; }

        string City { get; set; }
    }
}