using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class RequestBySearchTextValidator : AbstractValidator<RequestBySearchText>
    {
        public RequestBySearchTextValidator()
        {
            RuleFor(x => x.SearchText).Generic(0, int.MaxValue, Lang.SearchTextIsInvalid, nameof(Lang.SearchTextIsInvalid));

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.OffSet).Generic(0, int.MaxValue, "OffSet is invalid", "");

            RuleFor(x => x.Limit).Generic(0, 1000, "Limit is invalid", "");
        }
    }
}