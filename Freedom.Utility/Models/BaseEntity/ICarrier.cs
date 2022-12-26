namespace Freedom.Utility.Models.BaseEntity
{
    public interface ICarrier
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        string Person { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        string Mobile { get; set; }
    }
}