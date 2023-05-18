using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
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