using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    public class BankAccountDto : IBankAccount
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int BankId { get; set; }

        public int MoneyId { get; set; }

        public int BankAccountTypeId { get; set; }

        public string AccountNum { get; set; }

        public string AccountHolder { get; set; }

        public string CreditOfficer { get; set; }

        public string Agency { get; set; }

        public string Phone { get; set; }
    }
}