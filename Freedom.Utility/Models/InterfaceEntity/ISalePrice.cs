namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ISalePrice
    {
        int ProductId { get; set; }

        int Level { get; set; }

        int MoneyId { get; set; }

        int CompanyId { get; set; }

        decimal ValuePrice { get; set; }

        int QuantityPrice { get; set; }

        int Installment { get; set; }
    }
}