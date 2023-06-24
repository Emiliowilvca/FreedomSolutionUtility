using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class SaleRTO : SaleDto, ISaleRTO
    {
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