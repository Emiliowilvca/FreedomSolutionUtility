namespace Freedom.Utility.Models.BaseRTO
{
    public interface IEmployeeRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        string City { get; set; }

        string Identity { get; set; }

        string Phone { get; set; }

        string JobPost { get; set; }

        string JobSector { get; set; }

        int JobPostId { get; set; }

        int JobSectorId { get; set; }

        int CityId { get; set; }
    }
}