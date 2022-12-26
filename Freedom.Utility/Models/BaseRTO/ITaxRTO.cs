namespace Freedom.Utility.Models.BaseRTO
{
    public interface ITaxRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        decimal TaxRate { get; set; }
    }
}