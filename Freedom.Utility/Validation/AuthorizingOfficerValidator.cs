using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class AuthorizingOfficerValidator : AbstractValidator<IAuthorizingOfficer>
    {
        public AuthorizingOfficerValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.FullName).Generic(1, 50, Lang.FullNameIsInvalid, nameof(Lang.FullNameIsInvalid));

            RuleFor(x => x.CardId).Generic(1, 15, Lang.Validate_CardId, nameof(Lang.Validate_CardId));

            RuleFor(x => x.Address).Generic(0, 100, Lang.FieldAddressIsNotValid, nameof(Lang.FieldAddressIsNotValid));

            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.PhoneNumber).PhoneNumber(0, 15);

            RuleFor(x => x.BirthDate).BirthDate();
        }
    }
}