namespace Freedom.Utility.Models.BaseEntity
{
    public interface IShop
    {
        int Id { get; set; }

        string Address { get; set; }

        string BranchManager { get; set; }

        int CityId { get; set; }

        int CompanyId { get; set; }

        string Mail { get; set; }

        string Phone { get; set; }

        string Name { get; set; }
    }
}