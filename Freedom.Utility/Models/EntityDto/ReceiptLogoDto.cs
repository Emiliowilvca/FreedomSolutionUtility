using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class ReceiptLogoDto : IReceiptLogo
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }
        public Guid Image1 { get; set; }
        public Guid Image2 { get; set; }
        public Guid Image3 { get; set; }
        public Guid Image4 { get; set; }
        public Guid Image5 { get; set; }
        public Guid Image6 { get; set; }
        public Guid Image7 { get; set; }
        public Guid Image8 { get; set; }
        public Guid Image9 { get; set; }
        public Guid Image10 { get; set; }
        public Guid Image11 { get; set; }
        public Guid Image12 { get; set; }
    }
}