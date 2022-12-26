using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class UserSettingRequestValidator : AbstractValidator<UserSettingRequest>
    {
        public UserSettingRequestValidator()
        {
            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.UserSettingId).NotNull()
                                            .WithMessage(Lang.UserSettingIsInvalid)
                                            .WithErrorCode(nameof(Lang.UserSettingIsInvalid))
                                        .InclusiveBetween(1, int.MaxValue)
                                            .WithErrorCode(nameof(Lang.UserSettingIsInvalid))
                                            .WithMessage(Lang.UserSettingIsInvalid);
        }
    }
}