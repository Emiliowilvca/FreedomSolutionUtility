using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface ISaleRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        DateTime SalesDate { get; set; }

        long? Invoice { get; set; }

        string CustomerName { get; set; }

        string CustomerRuc { get; set; }

        string PersonName { get; set; }

        string PersonRuc { get; set; }

        int ShopId { get; set; }

        int BoxId { get; set; }

        int MoneyId { get; set; }

        int CustomerId { get; set; }

        int CustomerAccountId { get; set; }

        int PersonId { get; set; }

        int EmployeeId { get; set; }

        Guid SerialId { get; set; }

        Guid UserId { get; set; }

        int OperationTypeId { get; set; }

        string MoneyName { get; set; }

        string OperationTypeName { get; set; }

        string BoxName { get; set; }

        string ShopName { get; set; }

        decimal Exchange { get; set; }

        decimal TotalGross { get; set; }

        decimal TotalCost { get; set; }

        decimal TotalDiscount { get; set; }

        decimal TotalTax { get; set; }

        decimal TotalNet { get; set; }
    }
}