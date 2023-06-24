namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ICountry
    {
        int Id { get; set; }

        int CompanyId { get; set; }
        
        string Name { get; set; }
    }
}