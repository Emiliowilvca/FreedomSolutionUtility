using FluentValidation;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;
using Freedom.Utility.Variables;

namespace Freedom.Utility.ValidationRequest
{
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.Password).Password(GlobalStatic.PasswordMinLength, GlobalStatic.PasswordMaxLength);
        }
    }
}