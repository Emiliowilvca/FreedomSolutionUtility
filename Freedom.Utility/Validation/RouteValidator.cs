using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class RouteValidator : AbstractValidator<IRoute>
    {
        public RouteValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.ZoneId).Generic(1, int.MaxValue, Lang.ZoneIdIsInvalid, nameof(Lang.ZoneIdIsInvalid));
        }
    }
}