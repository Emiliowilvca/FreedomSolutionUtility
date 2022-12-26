using Freedom.Utility.Models.BaseRTO;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Models.RTO
{
    public class UserSettingRTO : IUserSettingRTO
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public int CompanyId { get; set; }

        public int BoxId { get; set; }

        public int EmployeeId { get; set; }

        public int MaxLevelPrice { get; set; }

        public int MaxDiscountRate { get; set; }

        public string OperationTypes { get; set; }

        public string Groups { get; set; }

        public string Zones { get; set; }

        public Role Role { get; set; }

        public BoxRTO BoxRTO { get; set; }

        public EmployeeRTO EmployeeRTO { get; set; }

        public IEnumerable<GroupRTO> GroupRTOCollection { get; set; } = new List<GroupRTO>();

        public IEnumerable<OperationTypeRTO> OperationTypeRTOCollection { get; set; } = new List<OperationTypeRTO>();

        public IEnumerable<ZoneRTO> ZoneRTOCollection { get; set; } = new List<ZoneRTO>();
    }
}