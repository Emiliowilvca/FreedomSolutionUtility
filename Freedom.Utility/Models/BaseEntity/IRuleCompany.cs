namespace Freedom.Utility.Models.BaseEntity
{
    public interface IRuleCompany : IEntity
    {
        string RuleKey { get; set; }

        int ShopId { get; set; }

        int CompanyID { get; set; }

        string ValueString { get; set; }
        
    }
}