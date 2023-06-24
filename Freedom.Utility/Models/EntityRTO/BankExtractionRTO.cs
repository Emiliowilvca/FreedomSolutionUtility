using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class BankExtractionRTO : BankExtractionDto, IBankExtractionRTO
    {
        public string OpType { get; set; }
    }
}