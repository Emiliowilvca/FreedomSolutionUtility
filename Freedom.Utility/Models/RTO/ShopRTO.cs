using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class ShopRTO :  IShopRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public string Address { get; set; }

        public string CityName { get; set; }

        public string BranchManager { get; set; }

        public int cityId { get; set; }

        public int CompanyId { get; set; }
    }
}