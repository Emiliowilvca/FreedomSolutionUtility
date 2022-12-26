using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPurchaseFees : IEntity
    {
        int CompanyId { get; set; }

        int PurchaseId { get; set; }

        byte NumberFees { get; set; }

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