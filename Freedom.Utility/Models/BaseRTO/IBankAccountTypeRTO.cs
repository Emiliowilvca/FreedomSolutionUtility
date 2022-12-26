namespace Freedom.Utility.Models.BaseRTO
{
    public interface IBankAccountTypeRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }
    }
}