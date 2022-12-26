using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Validation
{
    public class CompanyValidator : AbstractValidator<ICompany>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Id).NotNull();

            RuleFor(x => x.Name).NotNull().WithMessage(Lang.FieldNameIsNotValid).Length(1, 50).WithMessage(Lang.FieldNameIsNotValid);

            RuleFor(x => x.CompanyOwner).NotNull().WithMessage(Lang.FieldOwnerIsNotValid).Length(1, 50).WithMessage(Lang.FieldOwnerIsNotValid);

            RuleFor(x => x.Email).NotNull().WithMessage(Lang.Validate_Email).EmailAddress().WithMessage(Lang.Validate_Email);

            RuleFor(x => x.WhatsappPhoneNumber).NotNull().WithMessage(Lang.FieldWhatsappIsNotValid).Length(1, 20).WithMessage(Lang.FieldWhatsappIsNotValid);

            RuleFor(x => x.FacebookAdress).NotNull().WithMessage(Lang.FieldFacebookAddressIsNotValid).Length(1, 80).WithMessage(Lang.FieldFacebookAddressIsNotValid);

            RuleFor(x => x.PhoneNumber).NotNull().WithMessage(Lang.FieldPhoneNumberIsNotValid).Length(1, 20).WithMessage(Lang.FieldPhoneNumberIsNotValid);

            RuleFor(x => x.City).NotNull().WithMessage(Lang.FieldCityIsNotValid).Length(1, 80).WithMessage(Lang.FieldCityIsNotValid);

            RuleFor(x => x.Country).NotNull().WithMessage(Lang.FieldCityIsNotValid).Length(1, 80).WithMessage(Lang.FieldCountryIsNotValid);

            RuleFor(x => x.Address).NotNull().WithMessage(Lang.FieldAddressIsNotValid).Length(1, 120).WithMessage(Lang.FieldAddressIsNotValid);

            RuleFor(x => x.State).NotNull().WithMessage(Lang.FieldStateIsNotValid).Length(1, 80).WithMessage(Lang.FieldStateIsNotValid);
        }
    }
}