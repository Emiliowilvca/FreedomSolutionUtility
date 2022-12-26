namespace Freedom.Utility.Models.BaseRTO
{
    public interface IShopRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        string Phone { get; set; }

        string Mail { get; set; }

        string Address { get; set; }

        string BranchManager { get; set; }

        string CityName { get; set; }

        int cityId { get; set; }
    }
}