using FluentValidation;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;
using Freedom.Utility.Variables;

namespace Freedom.Utility.ValidationRequest
{
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator()
        {
            RuleFor(x => x.NewPassword).Password(GlobalStatic.PasswordMinLength, GlobalStatic.PasswordMaxLength);

            RuleFor(x => x.OldPassword).Password(GlobalStatic.PasswordMinLength, GlobalStatic.PasswordMaxLength);
        }
    }
}