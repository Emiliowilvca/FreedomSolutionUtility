using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class UserValidator : AbstractValidator<IUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.FullName).Generic(1, 100, Lang.FieldNameIsNotValid, nameof(Lang.FieldNameIsNotValid));

            RuleFor(x => x.Document).Generic(1, 20, Lang.IdentityNumberIsNotValid, nameof(Lang.IdentityNumberIsNotValid));

            RuleFor(x => x.Address).Address(1, 100);

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.CityId).CityID();

            RuleFor(x => x.PhoneNumber).PhoneNumber(1, 20);
        }
    }
}