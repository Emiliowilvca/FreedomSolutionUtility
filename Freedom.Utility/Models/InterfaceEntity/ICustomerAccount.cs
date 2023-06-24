using System;

namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ICustomerAccount
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int AccountNum { get; set; }

        string Name { get; set; }

        int CustomerId { get; set; }

        int MoneyId { get; set; }

        int ShopId { get; set; }

        int EmployeeId { get; set; }

        decimal CreditLimit { get; set; }

        bool Active { get; set; }

            DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }
    }
}