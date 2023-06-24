using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IBankDepositRTO : IBankDeposit
    {
        string OpInitials { get; set; }

        string MoneySymbol { get; set; }

        string BankAccount { get; set; }

        decimal TotalAmount { get; set; }
    }
}