﻿using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    public class AuthorizedStaffDto : IAuthorizedStaff
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public string CardId { get; set; }

        public int CompanyId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public int Id { get; set; }
    }
}