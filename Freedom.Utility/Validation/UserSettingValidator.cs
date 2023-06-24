using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class UserSettingValidator : AbstractValidator<IUserSetting>
    {
        public UserSettingValidator()
        {
            RuleFor(x => x.UserId).UserID();

            RuleFor(x => x.BoxId).BoxID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.EmployeeId).EmployeeID();
        }
    }
}