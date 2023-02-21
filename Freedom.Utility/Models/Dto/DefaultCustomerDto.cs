using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class DefaultCustomerDto : IEntity, IDefaultCustomer
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int CustomerAccountId { get; set; }

        public int CustomerId { get; set; }

        public int PersonId { get; set; }

        public int MoneyId { get; set; }
    }
}