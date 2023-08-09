using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class ScaleWeightSettingValidator : AbstractValidator<IScaleWeightSetting>
    {
        public ScaleWeightSettingValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.MeasureId).Generic(1, int.MaxValue, Lang.MeasureIsInvalid, nameof(Lang.MeasureIsInvalid));
        }
    }
}