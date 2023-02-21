using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class JobSectorDto : IEntity, IJobSector
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }
    }
}