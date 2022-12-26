using System;

namespace Freedom.Utility.Models.BaseEntity
{
    /// <summary>
    /// Persona autorizado a retirar mercaderia o servicios de parte del cliente
    /// </summary>
    public interface IAuthorizedStaff : IEntity
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