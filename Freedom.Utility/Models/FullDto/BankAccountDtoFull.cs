using Freedom.Utility.Models.Dto;

namespace Freedom.Utility.Models.FullDto
{
    public class BankAccountDtoFull : BankAccountDto
    {
        public string MoneyName { get; set; }

        public string BankName { get; set; }

        public string BankAccountTypeName { get; set; }
    }
}