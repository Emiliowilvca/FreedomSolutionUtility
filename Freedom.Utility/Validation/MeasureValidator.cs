﻿using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class MeasureValidator : AbstractValidator<IMeasure>
    {
        public MeasureValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);
        }
    }
}