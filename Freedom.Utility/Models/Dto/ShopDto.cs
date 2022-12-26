using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class ShopDto : IEntity, IShop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string BranchManager { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }
    }
}