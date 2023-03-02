using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class BoxDto : IEntity, IBox
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ShopId { get; set; }

        public int MoneyId { get; set; }

        public string Name { get; set; }
    }
}