using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class SectorProductDto : IEntity, ISectorProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int CompanyId { get; set; }
    }
}