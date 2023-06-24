using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class CustomerDebtDetailRTO : SaleFeesDto, ICustomerDebtDetailRTO
    {
        public int SaleFeesId { get; set; }

        public long? Invoice { get; set; }

        public int ShopId { get; set; }

        public string ShopName { get; set; }

        public int BoxId { get; set; }

        public string BoxName { get; set; }

        public DateTime SaleDate { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string UserName { get; set; }

        public decimal TotalTax { get; set; }

        public decimal TotalNet { get; set; }

        public decimal TotalGross { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal InterestOnArrears { get; set; }

        public decimal PartialPayment { get; set; }

        public decimal BalanceFees { get; set; }

        public decimal DaysLate { get; set; }

        public decimal ImputValue { get; set; }

        public int CompanyId { get; set; }

        public DateTime SalesDate { get; set; }

        public Guid UserId { get; set; }

        public int OperationTypeId { get; set; }

        public int PersonId { get; set; }

        public Guid SerialId { get; set; }

        public decimal TotalCost { get; set; }

        public bool IsExpress { get; set; }
    }
}