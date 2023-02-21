namespace Freedom.Utility.Models.BaseEntity
{
    public interface IDefaultCustomer
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int CustomerAccountId { get; set; }

        int CustomerId { get; set; }

        int PersonId { get; set; }

        int MoneyId { get; set; }
    }
}