using FluentValidation;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class EmailRequestValidator : AbstractValidator<EmailRequest>
    {
        public EmailRequestValidator()
        {
            RuleFor(x => x.Email).EmailRequest();
        }
    }
}