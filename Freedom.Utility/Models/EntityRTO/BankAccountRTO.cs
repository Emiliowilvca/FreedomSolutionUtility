using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class BankAccountRTO : BankAccountDto, IBankAccountRTO
    {
        public string Bank { get; set; }

        public string Money { get; set; }

        public string BankAccountTypeName { get; set; }
    }
}