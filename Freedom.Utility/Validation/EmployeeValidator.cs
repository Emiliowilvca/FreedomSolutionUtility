using FluentValidation;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class EmployeeValidator : AbstractValidator<IEmployee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Identity).Identity(1, 15);

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.Address).Address(1, 50);

            RuleFor(x => x.Barcode).Barcode(1, 12);

            RuleFor(x => x.Phone).PhoneNumber(1, 12);

            RuleFor(x => x.JobSectorId).JobSectorID();

            RuleFor(x => x.JobPostId).JobPostID();

            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.PhoneMobile).MobileNumber(1, 12);

            RuleFor(x => x.CityId).CityID();

            RuleFor(x => x.Salary).Salary();

            RuleFor(x => x.CommissionSales).CommissionSale();

            RuleFor(x => x.CommissionCollection).CommissionCollection();

            RuleFor(p => p.BirtDate).BirthDate();

            RuleFor(p => p.PlaceBirt).PlaceBirt(1, 100);

            RuleFor(p => p.Sex).Sex(1, 20);

            RuleFor(p => p.WorkStarDate).WorkStartDate();

            RuleFor(x => x.ChildCount).ChildCount();

            RuleFor(x => x.CivilStatus).CivilStatus(1, 20);

            RuleFor(x => x.Profession).Profession(1, 25);

            RuleFor(x => x.IpsEmployer).NotNull().WithMessage("IpsEmployer is required");

            RuleFor(x => x.IpsWorked).NotNull().WithMessage("IpsWorked is required");

            RuleFor(x => x.IsCommissionAgent).NotNull().WithMessage("CommissionAgent is required");

            RuleFor(x => x.FatherName).FatherName(1, 50);

            RuleFor(x => x.MotherName).MotherName(1, 50);

            RuleFor(x => x.BloodType).BloodType(1, 10);

            RuleFor(x => x.Nick).NickName(0, 50);

            RuleFor(x => x.PassportNum).PasaportNum(0, 15);

            RuleFor(x => x.SpouceCI).SpouceIdentity(0, 15);

            RuleFor(x => x.SpouceName).SpouceIdentity(0, 50);

            RuleFor(x => x.DrivingLicenceNum).DrivingLicenceNum(0, 15);

            RuleFor(x => x.EmergencyContact1).EmergencyContact1(0, 12);

            RuleFor(x => x.EmergencyContact2).EmergencyContact2(0, 12);

            RuleFor(x => x.Supervisor).NotNull().WithMessage("Supervisor is required");

            RuleFor(x => x.ActiveWorked).NotNull().WithMessage("ActiveWorked is required");

            RuleFor(x => x.Obs).Generic(1, 100, "Obs is Invalid", "");
        }
    }
}