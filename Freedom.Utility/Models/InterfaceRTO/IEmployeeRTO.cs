using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IEmployeeRTO : IEmployee
    {
        string City { get; set; }

        string JobPost { get; set; }

        string JobSector { get; set; }
    }
}