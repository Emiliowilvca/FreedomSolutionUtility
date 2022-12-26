namespace Freedom.Utility.Models.BaseEntity
{
    public interface IBank
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
    }
}