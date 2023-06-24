using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class BankRTO : BankDto, IBankRTO
    {
        public string City { get; set; }
    }
}