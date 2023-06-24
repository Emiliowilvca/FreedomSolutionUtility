using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class ProductImageDto : IProductImage
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CompanyId { get; set; }

        public int PhotoIndex { get; set; } 
        
        public Guid PhotoId { get; set; }

        public byte[] PhotoObject { get; set; }

    }
}