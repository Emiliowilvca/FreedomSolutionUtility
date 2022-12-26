using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class CityDto : IEntity, ICity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StateId { get; set; }

        public int CompanyId { get; set; }
    }
}