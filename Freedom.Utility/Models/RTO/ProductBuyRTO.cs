namespace Freedom.Utility.Models.RTO
{
    /// <summary>
    /// Purchase Item transfer Object
    /// </summary>
    public class ProductBuyRTO
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public decimal TaxRate { get; set; }

        public bool IsService { get; set; }

        public bool ProCheck { get; set; }

        public decimal CostPrice { get; set; }

        public int MoneyId { get; set; }
         
    }
}