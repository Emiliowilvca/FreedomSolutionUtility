using Freedom.Utility.Models.BaseDTO;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class SaleRTO : SaleBase, ISaleRTO
    {
        public string CustomerAccount { get; set; }

        public string AccountName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerName { get; set; }

        public string CustomerRuc { get; set; }

        public string EmployeeName { get; set; }

        public string AuthorizedStaff { get; set; }

        public string AuthorizingOfficer { get; set; }

        public string BoxName { get; set; }

        public int DecimalPlaces { get; set; }

        public string MoneyName { get; set; }

        public string OperationTypeName { get; set; }

        public string ShopName { get; set; }

        public string UserName { get; set; }
    }
}