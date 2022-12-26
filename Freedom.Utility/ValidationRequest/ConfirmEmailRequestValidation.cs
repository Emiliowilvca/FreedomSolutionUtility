using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class ConfirmEmailRequestValidation : AbstractValidator<ConfirmEmailRequest>
    {
        public ConfirmEmailRequestValidation()
        {
            RuleFor(x => x.VerificationCode).NotNull()
                                            .WithErrorCode(nameof(Lang.ValidationCodeIsInvalid))
                                            .WithMessage(Lang.ValidationCodeIsInvalid)
                                         .InclusiveBetween(100000, 9999999)
                                              .WithErrorCode(nameof(Lang.ValidationCodeIsInvalid))
                                            .WithMessage(Lang.ValidationCodeIsInvalid);

            RuleFor(x => x.Email).EmailRequest();
        }
    }
}