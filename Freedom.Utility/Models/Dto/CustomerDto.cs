using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    public class CustomerDto : ICustomer
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string TradeName { get; set; }

        public string Ruc { get; set; }

        public string Telephone { get; set; }

        public string Mobile1 { get; set; }

        public string Mobile2 { get; set; }

        public int CityId { get; set; }

        public int CategoryId { get; set; }

        public int BranchId { get; set; }

        public int RouteId { get; set; }

        public string WorkPlace { get; set; }

        public string Partner { get; set; }

        public int PartnerCI { get; set; }

        public DateTime ResidenceDate { get; set; }

        public bool OwnHouse { get; set; }

        public bool SendMoneyColletor { get; set; }

        public bool LendProducts { get; set; }

        public bool Credit { get; set; }

        public string Workphone { get; set; }

        public DateTime EmployementDate { get; set; }

        public string Email { get; set; }

        public string Goods { get; set; }

        public DateTime DateAdmin { get; set; }

        public DateTime BirthDate { get; set; }

        public byte Children { get; set; }

        public byte Gender { get; set; }

        public byte PriceLevel { get; set; }

        public decimal MaxDiscount { get; set; }

        public string Note { get; set; }
    }
}