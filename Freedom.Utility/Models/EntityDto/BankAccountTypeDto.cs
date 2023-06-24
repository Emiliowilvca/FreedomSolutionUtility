using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class BankAccountTypeDto : IBankAccountType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }
    }
}