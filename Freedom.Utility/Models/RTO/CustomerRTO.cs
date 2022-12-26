using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class CustomerRTO : ICustomerRTO
    {
        public int Id { get; set; }
        
        public int CompanyId { get; set; }
        
        public string FullName { get; set; }
        
        public string Address { get; set; }
        
        public string TradeName { get; set; }
        
        public string Ruc { get; set; }
        
        public string Telephone { get; set; }
        
        public string Mobile1 { get; set; }
        
        public string City { get; set; }
        
        public int CityId { get; set; }
        
        public string Category { get; set; }
        
        public int CategoryId { get; set; }
        
        public string Branch { get; set; }
        
        public int BranchId { get; set; }
        
        public string Route { get; set; }
        
        public int RouteId { get; set; }
    }
}