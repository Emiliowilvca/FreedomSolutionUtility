using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    public class CustomerAccountDto : ICustomerAccount
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int AccountNum { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }

        public int MoneyId { get; set; }

        public int ShopId { get; set; }

        public int EmployeeId { get; set; }

        public decimal CreditLimit { get; set; }

        public bool Active { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}