using FluentValidation;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class BoxValidator : AbstractValidator<IBox>
    {
        public BoxValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ShopId).ShopID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.MoneyId).MoneyID();
        }
    }
}