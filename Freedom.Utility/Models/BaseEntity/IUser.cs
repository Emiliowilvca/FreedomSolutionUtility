using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IUser
    {
        Guid Id { get; set; }

        string FullName { get; set; }

        string Document { get; set; }

        string Address { get; set; }

        int CityId { get; set; }

        int CompanyId { get; set; }

        string UserRole { get; set; }

        bool IsSuperUser { get; set; }

        bool IsAvailable { get; set; }

        double Latitude { get; set; }

        double Longitude { get; set; }

        string UserName { get; set; }

        string Email { get; set; }

        string PhoneNumber { get; set; }
    }
}