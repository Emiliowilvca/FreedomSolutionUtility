using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class TownDto : IEntity, ITown
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }
    }
}