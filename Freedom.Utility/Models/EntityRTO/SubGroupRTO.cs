using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class SubGroupRTO : SubGroupDto, ISubGroupRTO
    {
        public string GroupName { get; set; }
    }
}