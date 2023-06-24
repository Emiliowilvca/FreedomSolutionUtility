using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class ApplyDto : IEntity, IApply
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyId { get; set; }
    }
}