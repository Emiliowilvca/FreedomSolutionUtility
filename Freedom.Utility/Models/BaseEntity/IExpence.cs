using System;

namespace Freedom.Utility.Models.BaseEntity
{
    public interface IExpence
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        DateTime DateExpence { get; set; }

        long InvoiceNum { get; set; }

        string Remark { get; set; }

        int ProviderId { get; set; }

        int OperationTypeId { get; set; }

        int MoneyId { get; set; }

        Guid UserId { get; set; }

        int ShopId { get; set; }

        int BoxId { get; set; }

        int ExpenceTypeId { get; set; }

        decimal TotalIva { get; set; }

        decimal TotalExenta { get; set; }

        decimal TotalGravada { get; set; }

        decimal TotalNeto { get; set; }

        decimal Exchange { get; set; }

        short Taxtype { get; set; }
    }
}