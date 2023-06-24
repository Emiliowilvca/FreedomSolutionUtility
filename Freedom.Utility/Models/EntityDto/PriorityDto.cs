using System;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class PriorityDto : IEntity, IPriority
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }
    }
}