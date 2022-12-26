using FluentValidation;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class RequestByLimitValidator : AbstractValidator<RequestByLimit>
    {
        public RequestByLimitValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.OffSet).Generic(0, int.MaxValue, "OffSet is invalid", "");

            RuleFor(x => x.Limit).Generic(0, 1000, "Limit is invalid", "");
        }
    }
}