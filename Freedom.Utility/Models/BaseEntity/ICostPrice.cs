namespace Freedom.Utility.Models.BaseEntity
{
    public interface ICostPrice
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int ProductId { get; set; }

        int MoneyId { get; set; }

        decimal CostValue { get; set; }
    }
}