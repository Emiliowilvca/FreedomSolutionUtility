using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class DrugDto : IEntity, IDrug
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }
    }
}