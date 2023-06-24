using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class UserRTO : UserDto, IUserRTO
    {
        public string CityName { get; set; }
    }
}