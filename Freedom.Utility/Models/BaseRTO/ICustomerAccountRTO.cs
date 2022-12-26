namespace Freedom.Utility.Models.BaseRTO
{
    public interface ICustomerAccountRTO
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int AccountNum { get; set; }

        string Name { get; set; }

        int CustomerId { get; set; }

        string CustomerFullName { get; set; }

        string Ruc { get; set; }

        int MoneyId { get; set; }

        string MoneyName { get; set; }

        int ShopId { get; set; }

        string ShopName { get; set; }

        int EmployeeId { get; set; }

        string EmployeeName { get; set; }

        decimal CreditLimit { get; set; }

        string CustomerPhone { get; set; }

        string CustomerCity { get; set; }
    }
}