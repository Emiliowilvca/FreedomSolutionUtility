using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class UserDto : IUser
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Document { get; set; }

        public string Address { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }

        public bool IsAvailable { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsSuperUser { get; set; }

        public string UserRole { get; set; }

        public string Password { get; set; }
    }
}