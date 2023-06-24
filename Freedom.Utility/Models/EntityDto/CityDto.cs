using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
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