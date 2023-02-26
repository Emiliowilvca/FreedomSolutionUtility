﻿using FluentValidation;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class WithholdingVouchersValidator : AbstractValidator<IWithholdingVouchers>
    {
        public WithholdingVouchersValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.VourchersType).Generic(1, 50, "WithholdingVouchers VourchersType is invalid", "");

            RuleFor(x => x.Code).Generic(1, 100, "WithholdingVouchers code is invalid", "");

            RuleFor(x => x.Description).Generic(1, 800, "WithholdingVouchers code is invalid", "");
        }
    }
}