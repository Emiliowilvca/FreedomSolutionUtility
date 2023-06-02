namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPurchaseInstallment : IEntity
    {
        int CompanyId { get; set; }

        int PurchaseId { get; set; }

        int FeeIndex { get; set; }

        int ProviderId { get; set; }

        decimal Capital { get; set; }

        decimal Interest { get; set; }

        decimal Feesvalue { get; set; }

        int MoneyId { get; set; }

        bool Status { get; set; }

        DateTime Expirate { get; set; }

        decimal Exchange { get; set; }
    }
}