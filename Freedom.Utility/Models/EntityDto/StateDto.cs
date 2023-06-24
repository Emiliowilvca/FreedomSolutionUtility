using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class StateDto : IEntity, IState
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public int CompanyId { get; set; }
    }
}