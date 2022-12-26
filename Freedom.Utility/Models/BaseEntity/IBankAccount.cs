namespace Freedom.Utility.Models.BaseEntity
{
    public interface IBankAccount
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int BankId { get; set; }

        int MoneyId { get; set; }

        int BankAccountTypeId { get; set; }

        string AccountNum { get; set; }

        string AccountHolder { get; set; }

        string CreditOfficer { get; set; }

        string Agency { get; set; }

        string Phone { get; set; }
    }
}