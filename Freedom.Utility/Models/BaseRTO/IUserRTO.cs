using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IUserRTO
    {
        Guid Id { get; set; }

        string FullName { get; set; }

        string Document { get; set; }

        string Address { get; set; }

        string CityName { get; set; }

        string PhoneNumber { get; set; }

        string Email { get; set; }

        string UserRole { get; set; }
    }
}