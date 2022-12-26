using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;
using Freedom.Utility.Variables;

namespace Freedom.Utility.Validation
{
    public class LoginValidator : AbstractValidator<ILogin>
    {
        public LoginValidator()
        {
            RuleFor(x => x.EndPoint).NotNull()
                                    .WithMessage(Lang.AccessPointIsNullOrEmpty)
                                    .WithErrorCode(nameof(Lang.AccessPointIsNullOrEmpty))
                                .NotEmpty()
                                    .WithMessage(Lang.AccessPointIsNullOrEmpty)
                                    .WithErrorCode(nameof(Lang.AccessPointIsNullOrEmpty));

            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.Password).Password(GlobalStatic.PasswordMinLength, GlobalStatic.PasswordMaxLength);
        }
    }
}