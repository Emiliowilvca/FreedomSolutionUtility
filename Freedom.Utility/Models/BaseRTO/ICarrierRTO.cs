namespace Freedom.Utility.Models.BaseRTO
{
    public interface ICarrierRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string Person { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        string Mobile { get; set; }
    }
}