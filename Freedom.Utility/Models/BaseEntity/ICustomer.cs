using System;

namespace Freedom.Utility.Models.BaseEntity
{

    public interface ICustomer
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string FullName { get; set; }

        string Address { get; set; }

        string TradeName { get; set; }

        string Ruc { get; set; }

        string Telephone { get; set; }

        string Mobile1 { get; set; }

        string Mobile2 { get; set; }

        int CityId { get; set; }

        int CategoryId { get; set; }

        /// <summary>
        /// work Activity
        /// </summary>
        int BranchId { get; set; }

        int RouteId { get; set; }

        string WorkPlace { get; set; }

        string Partner { get; set; }

        int PartnerCI { get; set; }

        DateTime ResidenceDate { get; set; }

        bool OwnHouse { get; set; }

        bool SendMoneyColletor { get; set; }

        bool LendProducts { get; set; }

        bool Credit { get; set; }

        string Workphone { get; set; }

        DateTime EmployementDate { get; set; }

        string Email { get; set; }

        string Goods { get; set; }

        DateTime DateAdmin { get; set; }

        DateTime BirthDate { get; set; }

        byte Children { get; set; }

        byte Gender { get; set; }

        byte PriceLevel { get; set; }

        decimal MaxDiscount { get; set; }

        string Note { get; set; }
    }
}