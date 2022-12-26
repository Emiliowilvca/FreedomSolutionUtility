using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class OperationTypeDto : IEntity, IOperationType
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public int SubclassId { get; set; }

        public string Intials { get; set; }

    }
}