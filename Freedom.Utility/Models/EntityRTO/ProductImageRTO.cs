using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class ProductImageRTO : IProductImageRTO
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int PhotoIndex { get; set; }

        public string PhotoUrl { get; set; }
    }
}