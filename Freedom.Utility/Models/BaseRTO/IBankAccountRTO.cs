namespace Freedom.Utility.Models.BaseRTO
{
    public interface IBankAccountRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int BankId { get; set; }

        string Bank { get; set; }

        int MoneyId { get; set; }

        string Money { get; set; }

        int BankAccountTypeId { get; set; }

        string BankAccountTypeName { get; set; }

        string AccountNum { get; set; }

        string AccountHolder { get; set; }

        string CreditOfficer { get; set; }

        string Agency { get; set; }

        string Phone { get; set; }
    }
}