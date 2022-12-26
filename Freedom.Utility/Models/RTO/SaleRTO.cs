using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class SaleRTO : ISaleRTO
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime SalesDate { get; set; }

        public long? Invoice { get; set; }

        public int ShopId { get; set; }

        public int BoxId { get; set; }

        public Guid UserId { get; set; }
         
        public int OperationTypeId { get; set; }
          
        public int MoneyId { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int PersonId { get; set; }

        public int EmployeeId { get; set; }

        public Guid SerialId { get; set; }

        public decimal Exchange { set; get; }

        public decimal TotalGross { get; set; }

        public decimal TotalCost { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalTax { get; set; }

        public decimal TotalNet { get; set; }

        public string CustomerRuc { get; set; }

        public string PersonRuc { get; set; }

        public string BoxName { get; set; }

        public string ShopName { get; set; }

        public string UserName { get; set; }

        public string OperationTypeName { get; set; }

        public string MoneyName { get; set; }

        public string CustomerName { get; set; }

        public string PersonName { get; set; }

        public string EmployeeName { get; set; }
    }
}