using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IUserRTO : IUser
    {
        string CityName { get; set; }
    }
}