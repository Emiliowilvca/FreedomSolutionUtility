namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPrice
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int ProductId { get; set; }

        int MoneyId { get; set; }

        short Level { get; set; }

        decimal ValuePrice { get; set; }
         
        short QuantityPrice { get; set; }

        byte TypePrice { get; set; }
    }
}