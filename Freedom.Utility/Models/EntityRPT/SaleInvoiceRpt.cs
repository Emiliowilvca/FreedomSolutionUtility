using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityRPT
{
    public class SaleInvoiceRpt : ISale
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime SalesDate { get; set; }

        public long? Invoice { get; set; }

        public int ShopId { get; set; }

        public int BoxId { get; set; }

        public Guid UserId { get; set; }

        public int MoneyId { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int PersonId { get; set; }

        public int EmployeeId { get; set; }

        public Guid SerialId { get; set; }

        public decimal Exchange { get; set; }

        public decimal TotalGross { get; set; }

        public decimal TotalCost { get; set; }

        public decimal TotalNet { get; set; }

        public bool Status { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerRuc { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAccount { get; set; }

        public string PersonName { get; set; }

        public string PersonAddress { get; set; }

        public string PersonRuc { get; set; }

        public string PersonPhone { get; set; }

        public string UserName { get; set; }

        public string SaleCondition { get; set; }

        public int OperationTypeId { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalTax { get; set; }

        public string AuthorizedStaff { get; set; }

        public string AuthorizingOfficer { get; set; }

        public string CompanyName { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }

        public string CompanyCountry { get; set; }

        public string CompanyAddress { get; set; }

        public string ShopName { get; set; }

        public string BoxName { get; set; }

        public string EmployeeName { get; set; }

        public string AccountName { get; set; }

        public string MoneyName { get; set; }

        public int DecimalPlaces { get; set; }

        public bool IsExpress { get; set; }

        public IEnumerable<SaleDetailRpt> SaleDetails { get; set; }
    }
}