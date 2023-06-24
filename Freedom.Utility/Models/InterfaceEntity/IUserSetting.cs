using System;

namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IUserSetting
    {
        int Id { get; set; }

        Guid UserId { get; set; }

        int CompanyId { get; set; }

        int BoxId { get; set; }

        int EmployeeId { get; set; }

        int MaxLevelPrice { get; set; }

        int MaxDiscountRate { get; set; }

        string OperationTypes { get; set; }

        string Groups { get; set; }

        string Zones { get; set; }
    }
}