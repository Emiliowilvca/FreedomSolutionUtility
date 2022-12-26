using Freedom.Utility.Models.Dto;

namespace Freedom.Utility.Models.FullDto
{
    public class CustomerAccountDtoFull : CustomerAccountDto
    {
        public string CustomerName { get; set; }

        public string ShopName { get; set; }

        public string MoneyName { get; set; }

        public string EmployeeName { get; set; }
    }
}