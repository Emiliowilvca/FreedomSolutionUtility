using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class UserSettingRTO : UserSettingDto, IUserSettingRTO
    {
        public Role Role { get; set; }

        public BoxRTO BoxRTO { get; set; }

        public EmployeeRTO EmployeeRTO { get; set; }

        public IEnumerable<GroupRTO> GroupRTOCollection { get; set; } = new List<GroupRTO>();

        public IEnumerable<OperationTypeRTO> OperationTypeRTOCollection { get; set; } = new List<OperationTypeRTO>();

        public IEnumerable<ZoneRTO> ZoneRTOCollection { get; set; } = new List<ZoneRTO>();
    }
}