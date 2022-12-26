namespace Freedom.Utility.Models.BaseEntity
{
    public interface IRoles
    {
        bool Admin { get; set; }
        bool Customer { get; set; }
        bool Finance { get; set; }
        bool Investor { get; set; }
        bool Operator { get; set; }
        bool Provider { get; set; }
        bool SuperUser { get; set; }
        bool Seller { get; set; }
    }
}