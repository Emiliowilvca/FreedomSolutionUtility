using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IBankAccountRTO : IBankAccount
    {
        string Bank { get; set; }

        string Money { get; set; }

        string BankAccountTypeName { get; set; }
    }
}