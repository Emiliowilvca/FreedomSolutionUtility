using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class BankDepositRTO : BankDepositDto, IBankDepositRTO
    {
        public string OpInitials { get; set; }

        public string MoneySymbol { get; set; }

        public string BankAccount { get; set; }

        public decimal TotalAmount { get; set; }
    }
}