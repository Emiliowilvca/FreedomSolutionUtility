namespace Freedom.Utility.Models.BaseEntity
{
    public interface IBox
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int ShopId { get; set; }

        int MoneyId { get; set; }
         
        string Name { get; set; }

    }
}