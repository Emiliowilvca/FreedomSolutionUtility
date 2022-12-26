namespace Freedom.Utility.Models.BaseRTO
{
    public interface IBoxRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int ShopId { get; set; }

        int MoneyId { get; set; }

        string Name { get; set; }

        string ShopName { get; set; }

        string MoneyName { get; set; }
    }
}