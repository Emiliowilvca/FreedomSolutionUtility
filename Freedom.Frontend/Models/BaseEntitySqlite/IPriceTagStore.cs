namespace Freedom.Frontend.Models.BaseEntitySqlite
{
    public interface IPriceTagStore
    {
        Guid Id { get; set; }

        int CompanyId { get; set; }

        int ShopId { get; set; }

        Guid UserId { get; set; }

        DateTime StoreDate { get; set; }

        string UserName { get; set; }

        string CompanyName { get; set; }

        string ShopName { get; set; }

        public string JsonModel { get; set; }
    }
}