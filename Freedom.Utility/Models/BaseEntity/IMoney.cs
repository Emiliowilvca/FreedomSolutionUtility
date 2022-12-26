namespace Freedom.Utility.Models.BaseEntity
{
    public interface IMoney
    {
        int Id { get; set; }

        string Name { get; set; }

        int CompanyId { get; set; }

        int DecimalPlaces { get; set; }

        decimal Exchange { get; set; }

        /// <summary>
        /// Codigo ISO Ej. USD, PYG
        /// </summary>
        string IsoCode { get; set; }
         
        bool MoneyBase { get; set; }

        string Symbol { get; set; }

        decimal CommisionPercent { get; set; }

        int DefaultCustomerAccountId { get; set; }

        int DefaultCustomerId { get; set; }

        int DefaultPersonId { get; set; }
    }
}