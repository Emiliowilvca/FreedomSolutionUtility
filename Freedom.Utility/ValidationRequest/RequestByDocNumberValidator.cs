using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class RequestByDocNumberValidator : AbstractValidator<RequestByDocNumber>
    {
        public RequestByDocNumberValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.DocumentNumber).Generic(0, long.MaxValue, Lang.DocumentNumberIsInvalid, nameof(Lang.DocumentNumberIsInvalid));
        }
    }
}