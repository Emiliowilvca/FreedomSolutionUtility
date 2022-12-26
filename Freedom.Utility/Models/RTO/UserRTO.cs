﻿using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class UserRTO : IUserRTO
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Document { get; set; }

        public string Address { get; set; }

        public string CityName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string UserRole { get; set; }
    }
}