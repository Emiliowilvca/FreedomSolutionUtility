namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IProductImageRTO
    {
        int Id { get; set; }

        int PhotoIndex { get; set; }
        
        string PhotoUrl { get; set; }
        
        int ProductId { get; set; }
    }
}