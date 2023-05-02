namespace Freedom.Utility.Models.BaseEntity
{
    public interface ISalePrice
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int ProductId { get; set; }

        int MoneyId { get; set; }

        int Level { get; set; }

        decimal ValuePrice { get; set; }

        int QuantityPrice { get; set; }

        int Installment { get; set; }
    }
}