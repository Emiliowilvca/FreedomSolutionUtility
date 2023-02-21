using FluentValidation;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class MoneyValidator : AbstractValidator<IMoney>
    {
        public MoneyValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 25);

            RuleFor(x => x.Symbol).Symbol(1, 3);

            RuleFor(x => x.Exchange).Exchange(0m);

            RuleFor(x => x.MoneyBase).NotNull().WithMessage("MoneyBase Is required");

            RuleFor(x => x.CommisionPercent).CommissionPercent();

            RuleFor(x => x.DecimalPlaces).NotNull().WithMessage("DecimalPlaces Is required");

            RuleFor(x => x.IsoCode).NotNull().WithMessage("IsoCode is not valid")
                                   .MinimumLength(1).WithMessage("IsoCode is no Valid - min value")
                                   .MaximumLength(3).WithMessage("IsoCode is no Valid - max value");
        }
    }
}