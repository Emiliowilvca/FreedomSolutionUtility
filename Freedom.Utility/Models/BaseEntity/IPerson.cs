using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPerson : IEntity
    {
        string FullName { get; set; }

        string Address { get; set; }

        string CardId { get; set; }

        int CompanyId { get; set; }

        string Email { get; set; }

        string PhoneNumber { get; set; }

        DateTime BirthDate { get; set; }

        DateTime EnrollmentDate { get; set; }
    }
}