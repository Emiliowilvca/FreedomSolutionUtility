using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
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