﻿using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class JobPostValidator : AbstractValidator<IJobPost>
    {
        public JobPostValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);
        }
    }
}