﻿using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;
using Freedom.Utility.ValidatorExtension;


namespace Freedom.Utility.ValidationRequest
{
    public class RequestByIdValidator : AbstractValidator<RequestById>
    {
        public RequestByIdValidator()
        {
            RuleFor(x => x.SinceDate).Generic(Lang.DateSinceIsNotValid, nameof(Lang.DateSinceIsNotValid));

            RuleFor(x => x.UntilDate).Generic(Lang.DateUntilIsNotValid, nameof(Lang.DateUntilIsNotValid));

            RuleFor(x => x.Id).Generic(0, int.MaxValue, Lang.DateSinceIsNotValid, nameof(Lang.DateSinceIsNotValid));

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.OffSet).Generic(0, int.MaxValue, "OffSet is invalid", "");

            RuleFor(x => x.Limit).Generic(0, int.MaxValue, "Limit is invalid", "");
        }
    }
}