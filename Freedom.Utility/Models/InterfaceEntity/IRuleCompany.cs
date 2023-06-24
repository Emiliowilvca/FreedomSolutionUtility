namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IRuleCompany : IEntity
    {
        string RuleKey { get; set; }

        int ShopId { get; set; }

        int CompanyID { get; set; }

        string ValueString { get; set; }
        
    }
}