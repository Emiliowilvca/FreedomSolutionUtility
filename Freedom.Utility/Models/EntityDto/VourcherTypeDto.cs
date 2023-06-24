using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class VourcherTypeDto : IEntity, IVourcherType
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string NameSET { get; set; }

        public string CodeSET { get; set; }
    }
}