using System;

namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IEmployee
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        string Barcode { get; set; }

        string Phone { get; set; }

        string Identity { get; set; }

        int JobSectorId { get; set; }

        int JobPostId { get; set; }

        int CityId { get; set; }

        string PhoneMobile { get; set; }

        string Email { get; set; }

        decimal Salary { get; set; }

        decimal CommissionSales { get; set; }

        decimal CommissionCollection { get; set; }

        bool IsCommissionAgent { get; set; }

        DateTime BirtDate { get; set; }

        string PlaceBirt { get; set; }

        string Sex { get; set; }

        DateTime WorkStarDate { get; set; }

        int ChildCount { get; set; }

        string CivilStatus { get; set; }

        string Profession { get; set; }

        bool IpsEmployer { get; set; }

        bool IpsWorked { get; set; }

        bool ActiveWorked { get; set; }

        string FatherName { get; set; }

        string MotherName { get; set; }

        string BloodType { get; set; }

        string Nick { get; set; }

        string PassportNum { get; set; }

        string SpouceCI { get; set; }

        string SpouceName { get; set; }

        string DrivingLicenceNum { get; set; }

        string EmergencyContact1 { get; set; }

        string EmergencyContact2 { get; set; }

        bool Supervisor { get; set; }

        string Obs { get; set; }
    }
}