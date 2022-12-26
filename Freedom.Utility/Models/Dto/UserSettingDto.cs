using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class UserSettingDto : IEntity, IUserSetting
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public int CompanyId { get; set; }

        public int BoxId { get; set; }

        public int EmployeeId { get; set; }

        public int MaxLevelPrice { get; set; }

        public int MaxDiscountRate { get; set; }

        public Role Roles { get; set; }

        public string OperationTypes { get; set; }

        public string Groups { get; set; }

        public string Zones { get; set; }
    }
}