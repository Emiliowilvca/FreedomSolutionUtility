using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class EmployeeDto : IEntity, IEmployee
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Barcode { get; set; }

        public string Phone { get; set; }

        public string Identity { get; set; }

        public int JobSectorId { get; set; }

        public int JobPostId { get; set; }

        public int CityId { get; set; }

        public string PhoneMobile { get; set; }

        public string EMail { get; set; }

        public decimal Salary { get; set; }

        public decimal CommissionSales { get; set; }

        public decimal CommissionCollection { get; set; }

        public DateTime BirtDate { get; set; }

        public string PlaceBirt { get; set; }

        public string Sex { get; set; }

        public DateTime WorkStarDate { get; set; }

        public int ChildCount { get; set; }

        public string CivilStatus { get; set; }

        public string Profession { get; set; }

        public bool IpsEmployer { get; set; }

        public bool IpsWorked { get; set; }

        public bool ActiveWorked { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string BloodType { get; set; }

        public string Nick { get; set; }

        public string PassportNum { get; set; }

        public string SpouceCI { get; set; }

        public string SpouceName { get; set; }

        public string DrivingLicenceNum { get; set; }

        public string EmergencyContact1 { get; set; }

        public string EmergencyContact2 { get; set; }

        public bool Supervisor { get; set; }

        public string Obs { get; set; }

        public bool IsCommissionAgent { get; set; }
    }
}