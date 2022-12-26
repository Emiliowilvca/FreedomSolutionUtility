using Freedom.Utility.Models.BaseRTO;
using System.Collections.Generic;

namespace Freedom.Utility.Models.RTO
{
    public class CustomerDebtRTO : ICustomerDebtRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int AccountNum { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }

        public string CustomerFullName { get; set; }

        public string Ruc { get; set; }

        public int MoneyId { get; set; }

        public string MoneyName { get; set; }

        public int ShopId { get; set; }

        public string ShopName { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public decimal CreditLimit { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerCity { get; set; }

        public IEnumerable<CustomerDebtDetailRTO> CustomerDebtDetailRTO { get; set; }
        
    }
}