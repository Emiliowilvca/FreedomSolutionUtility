using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface ISubGroupRTO : ISubGroup
    {
        string GroupName { get; set; }
    }
}