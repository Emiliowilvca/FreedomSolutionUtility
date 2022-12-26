using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Variables;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Freedom.Utility.ValidatorExtension
{
    public static class RuleBuilderExtensions
    {
        #region ValidateString

        public static IRuleBuilder<T, string> Address<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.FieldAddressIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldAddressIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.FieldAddressIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldAddressIsNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.FieldAddressIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldAddressIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.FieldAddressIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldAddressIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> AccountNum<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.AccountNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.AccountNumberIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.AccountNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.AccountNumberIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.AccountNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.AccountNumberIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.AccountNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.AccountNumberIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> BankName<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.BankErrorMustSelect)
                                .WithErrorCode(nameof(Lang.BankErrorMustSelect))
                          .NotNull()
                                .WithMessage(Lang.BankErrorMustSelect)
                                .WithErrorCode(nameof(Lang.BankErrorMustSelect))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.BankErrorMustSelect)
                                .WithErrorCode(nameof(Lang.BankErrorMustSelect))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.BankErrorMustSelect)
                                .WithErrorCode(nameof(Lang.BankErrorMustSelect));
            return options;
        }

        public static IRuleBuilder<T, string> BranchManager<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.BranchManagerIsNoValid)
                                .WithErrorCode(nameof(Lang.BranchManagerIsNoValid))
                          .NotNull()
                                .WithMessage(Lang.BranchManagerIsNoValid)
                                .WithErrorCode(nameof(Lang.BranchManagerIsNoValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.BranchManagerIsNoValid)
                                .WithErrorCode(nameof(Lang.BranchManagerIsNoValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.BranchManagerIsNoValid)
                                .WithErrorCode(nameof(Lang.BranchManagerIsNoValid));
            return options;
        }

        public static IRuleBuilder<T, string> BloodType<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.BloodTypenameNotValid)
                                .WithErrorCode(nameof(Lang.BloodTypenameNotValid))
                          .NotNull()
                                .WithMessage(Lang.BloodTypenameNotValid)
                                .WithErrorCode(nameof(Lang.BloodTypenameNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.BloodTypenameNotValid)
                                .WithErrorCode(nameof(Lang.BloodTypenameNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.BloodTypenameNotValid)
                                .WithErrorCode(nameof(Lang.BloodTypenameNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> ContactName<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.ContactNameIsInvalid)
                                .WithErrorCode(nameof(Lang.ContactNameIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.ContactNameIsInvalid)
                                .WithErrorCode(nameof(Lang.ContactNameIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.ContactNameIsInvalid)
                                .WithErrorCode(nameof(Lang.ContactNameIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.ContactNameIsInvalid)
                                .WithErrorCode(nameof(Lang.ContactNameIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> CivilStatus<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.CivilStatusIsNotValid)
                                .WithErrorCode(nameof(Lang.CivilStatusIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.CivilStatusIsNotValid)
                                .WithErrorCode(nameof(Lang.CivilStatusIsNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.CivilStatusIsNotValid)
                                .WithErrorCode(nameof(Lang.CivilStatusIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.CivilStatusIsNotValid)
                                .WithErrorCode(nameof(Lang.CivilStatusIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> DrivingLicenceNum<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.DrivingLicenceNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.DrivingLicenceNumberIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.DrivingLicenceNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.DrivingLicenceNumberIsNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.DrivingLicenceNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.DrivingLicenceNumberIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.DrivingLicenceNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.DrivingLicenceNumberIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> EmailRequest<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.EmailRequired)
                                .WithErrorCode(nameof(Lang.EmailRequired))
                          .NotNull()
                                .WithMessage(Lang.EmailRequired)
                                .WithErrorCode(nameof(Lang.EmailRequired))
                          .EmailAddress()
                                .WithMessage(Lang.Email_Is_Invalid)
                                .WithErrorCode(nameof(Lang.Email_Is_Invalid));
            return options;
        }

        public static IRuleBuilder<T, string> EmergencyContact1<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.Emergency1NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency1NumberNotValid))
                          .NotNull()
                                .WithMessage(Lang.Emergency1NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency1NumberNotValid))
                           .MinimumLength(minimumLength)
                                .WithMessage(Lang.Emergency1NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency1NumberNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.Emergency1NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency1NumberNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> EmergencyContact2<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.Emergency2NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency2NumberNotValid))
                          .NotNull()
                                .WithMessage(Lang.Emergency2NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency2NumberNotValid))
                           .MinimumLength(minimumLength)
                                .WithMessage(Lang.Emergency2NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency2NumberNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.Emergency2NumberNotValid)
                                .WithErrorCode(nameof(Lang.Emergency2NumberNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> Barcode<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.barcodeIsNotValid)
                                .WithErrorCode(nameof(Lang.barcodeIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.barcodeIsNotValid)
                                .WithErrorCode(nameof(Lang.barcodeIsNotValid))
                           .MinimumLength(minimumLength)
                                .WithMessage(Lang.barcodeIsNotValid)
                                .WithErrorCode(nameof(Lang.mobileIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.mobileIsInvalid)
                                .WithErrorCode(nameof(Lang.barcodeIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> FatherName<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.FatherNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FatherNameIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.FatherNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FatherNameIsNotValid))
                           .MinimumLength(minimumLength)
                                .WithMessage(Lang.FatherNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FatherNameIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.FatherNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FatherNameIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> Identity<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.IdentityNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.IdentityNumberIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.IdentityNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.IdentityNumberIsNotValid))
                           .MinimumLength(minimumLength)
                                .WithMessage(Lang.IdentityNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.IdentityNumberIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.IdentityNumberIsNotValid)
                                .WithErrorCode(nameof(Lang.IdentityNumberIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> MotherName<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.MotherNameIsInvalid)
                                .WithErrorCode(nameof(Lang.MotherNameIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.MotherNameIsInvalid)
                                .WithErrorCode(nameof(Lang.MotherNameIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.MotherNameIsInvalid)
                                .WithErrorCode(nameof(Lang.MotherNameIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.MotherNameIsInvalid)
                                .WithErrorCode(nameof(Lang.MotherNameIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> MobileNumber<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.mobileIsInvalid)
                                .WithErrorCode(nameof(Lang.mobileIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.mobileIsInvalid)
                                .WithErrorCode(nameof(Lang.mobileIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.mobileIsInvalid)
                                .WithErrorCode(nameof(Lang.mobileIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.mobileIsInvalid)
                                .WithErrorCode(nameof(Lang.mobileIsInvalid))
                          .Matches(GlobalStatic.PhoneNumberRegex)
                                .WithMessage(Lang.mobileIsInvalid)
                                .WithErrorCode(nameof(Lang.mobileIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> Name<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.FieldNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.FieldNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.FieldNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.FieldNameIsNotValid)
                                .WithErrorCode(nameof(Lang.FieldNameIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> NickName<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.NickNameIsInvalid)
                                .WithErrorCode(nameof(Lang.NickNameIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.NickNameIsInvalid)
                                .WithErrorCode(nameof(Lang.NickNameIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.NickNameIsInvalid)
                                .WithErrorCode(nameof(Lang.NickNameIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.NickNameIsInvalid)
                                .WithErrorCode(nameof(Lang.NickNameIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> Remark<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder.NotNull()
                                            .WithMessage(Lang.RemarkIsNotValid)
                                            .WithErrorCode(nameof(Lang.RemarkIsNotValid))
                                     .MinimumLength(minimumLength)
                                            .WithMessage(Lang.RemarkIsNotValid)
                                            .WithErrorCode(nameof(Lang.RemarkIsNotValid))
                                      .MaximumLength(maximumLength)
                                             .WithMessage(Lang.RemarkIsNotValid)
                                            .WithErrorCode(nameof(Lang.RemarkIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> observation<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.ObservationIsNotValid)
                                .WithErrorCode(nameof(Lang.ObservationIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.ObservationIsNotValid)
                                .WithErrorCode(nameof(Lang.ObservationIsNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.ObservationIsNotValid)
                                .WithErrorCode(nameof(Lang.ObservationIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.ObservationIsNotValid)
                                .WithErrorCode(nameof(Lang.ObservationIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> PhoneNumber<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.Validate_PhoneNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.Validate_PhoneNumberIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.Validate_PhoneNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.Validate_PhoneNumberIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.Validate_PhoneNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.Validate_PhoneNumberIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.Validate_PhoneNumberIsInvalid)
                                 .WithErrorCode(nameof(Lang.Validate_PhoneNumberIsInvalid))
                          .Matches(GlobalStatic.PhoneNumberRegex)
                                .WithMessage(Lang.Validate_PhoneNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.Validate_PhoneNumberIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.PasswordError)
                                .WithErrorCode(nameof(Lang.PasswordError))
                          .NotNull()
                                .WithMessage(Lang.PasswordError)
                                .WithErrorCode(nameof(Lang.PasswordError))
                          .MinimumLength(minimumLength)
                                .WithMessage(Lang.PasswordMinimunLength)
                                .WithErrorCode(nameof(Lang.PasswordMinimunLength))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.PasswordMinimunLength)
                                .WithErrorCode(nameof(Lang.PasswordMinimunLength))
                          .Matches(GlobalStatic.PasswordRegex)
                                .WithMessage(Lang.PasswordError)
                                .WithErrorCode(nameof(Lang.PasswordError));
            return options;
        }

        public static IRuleBuilder<T, string> PasaportNum<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.PassportNumIsNotValid)
                                .WithErrorCode(nameof(Lang.PassportNumIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.PassportNumIsNotValid)
                                .WithErrorCode(nameof(Lang.PassportNumIsNotValid))
                          .MinimumLength(minimumLength)
                                .WithMessage(Lang.PassportNumIsNotValid)
                                .WithErrorCode(nameof(Lang.PassportNumIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.PassportNumIsNotValid)
                                .WithErrorCode(nameof(Lang.PassportNumIsNotValid));

            return options;
        }

        public static IRuleBuilder<T, string> PlaceBirt<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.PlaceBirtIsNotValid)
                                .WithErrorCode(nameof(Lang.PlaceBirtIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.PasswordError)
                                .WithErrorCode(nameof(Lang.PasswordError))
                          .MinimumLength(minimumLength)
                                .WithMessage(Lang.PasswordMinimunLength)
                                .WithErrorCode(nameof(Lang.PasswordMinimunLength))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.PasswordMinimunLength)
                                .WithErrorCode(nameof(Lang.PasswordMinimunLength));

            return options;
        }

        public static IRuleBuilder<T, string> Profession<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.ProfessionIsNotValid)
                                .WithErrorCode(nameof(Lang.ProfessionIsNotValid))
                          .NotNull()
                                .WithMessage(Lang.ProfessionIsNotValid)
                                .WithErrorCode(nameof(Lang.ProfessionIsNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.ProfessionIsNotValid)
                                .WithErrorCode(nameof(Lang.ProfessionIsNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.ProfessionIsNotValid)
                                 .WithErrorCode(nameof(Lang.ProfessionIsNotValid));

            return options;
        }

        public static IRuleBuilder<T, string> Ruc<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.RucNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.RucNumberIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.RucNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.RucNumberIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.RucNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.RucNumberIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.RucNumberIsInvalid)
                                .WithErrorCode(nameof(Lang.RucNumberIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, string> Sex<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.SexIsNotvalid)
                                .WithErrorCode(nameof(Lang.SexIsNotvalid))
                          .NotNull()
                                .WithMessage(Lang.SexIsNotvalid)
                                .WithErrorCode(nameof(Lang.SexIsNotvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.SexIsNotvalid)
                                .WithErrorCode(nameof(Lang.SexIsNotvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.SexIsNotvalid)
                                .WithErrorCode(nameof(Lang.SexIsNotvalid));
            return options;
        }

        public static IRuleBuilder<T, string> SpouceIdentity<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid))
                          .NotNull()
                                .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid));
            return options;
        }

        public static IRuleBuilder<T, string> SpouceName<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid))
                          .NotNull()
                                .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.SpouceIdentiyIsnotValid)
                                .WithErrorCode(nameof(Lang.SpouceIdentiyIsnotValid));
            return options;
        }

        public static IRuleBuilder<T, string> Symbol<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.Symbol)
                                .WithErrorCode(nameof(Lang.SymbolNotValid))
                          .NotNull()
                                .WithMessage(Lang.SymbolNotValid)
                                .WithErrorCode(nameof(Lang.SymbolNotValid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.SymbolNotValid)
                                .WithErrorCode(nameof(Lang.SymbolNotValid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.SymbolNotValid)
                                .WithErrorCode(nameof(Lang.SymbolNotValid));
            return options;
        }

        public static IRuleBuilder<T, string> Timbrado<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength, int maximumLength)
        {
            var options = ruleBuilder
                          .NotEmpty()
                                .WithMessage(Lang.StampIsInvalid)
                                .WithErrorCode(nameof(Lang.StampIsInvalid))
                          .NotNull()
                                .WithMessage(Lang.StampIsInvalid)
                                .WithErrorCode(nameof(Lang.StampIsInvalid))
                         .MinimumLength(minimumLength)
                                .WithMessage(Lang.StampIsInvalid)
                                .WithErrorCode(nameof(Lang.StampIsInvalid))
                          .MaximumLength(maximumLength)
                                 .WithMessage(Lang.StampIsInvalid)
                                .WithErrorCode(nameof(Lang.StampIsInvalid));
            return options;
        }

        #endregion ValidateString

        #region IdValidators

        public static IRuleBuilder<T, int> ID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithMessage(Lang.IdIsInvalid)
                                        .WithErrorCode(nameof(Lang.IdIsInvalid))
                                    .InclusiveBetween(0, int.MaxValue)
                                        .WithMessage(Lang.IdIsInvalid)
                                        .WithErrorCode(nameof(Lang.IdIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, int> BoxID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithMessage(Lang.BoxIdIsInvalid)
                                        .WithErrorCode(nameof(Lang.BoxIdIsInvalid))
                                    .InclusiveBetween(1, int.MaxValue)
                                        .WithMessage(Lang.BoxIdIsInvalid)
                                        .WithErrorCode(nameof(Lang.BoxIdIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, int> CarrierID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.CarrierIsInvalid))
                                        .WithMessage(Lang.CarrierIsInvalid)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.CarrierIsInvalid))
                                        .WithMessage(Lang.CarrierIsInvalid);
            return options;
        }

        public static IRuleBuilder<T, int> CityID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.City_ErrorMustSelect))
                                        .WithMessage(Lang.City_ErrorMustSelect)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.City_ErrorMustSelect))
                                        .WithMessage(Lang.City_ErrorMustSelect);
            return options;
        }

        public static IRuleBuilder<T, int> ChildCount<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.ChildrenNumberIsNotValid))
                                        .WithMessage(Lang.ChildrenNumberIsNotValid)
                                     .InclusiveBetween(0, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.ChildrenNumberIsNotValid))
                                        .WithMessage(Lang.ChildrenNumberIsNotValid);
            return options;
        }

        public static IRuleBuilder<T, int> CompanyID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Lang.Company_ErrorMustSelect)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Lang.Company_ErrorMustSelect);
            return options;
        }

        public static IRuleBuilder<T, int> EmployeeID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.EmployeeIdIsNull))
                                        .WithMessage(Lang.EmployeeIdIsNull)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.EmployeeIdIsNull))
                                        .WithMessage(Lang.EmployeeIdIsNull);
            return options;
        }

        public static IRuleBuilder<T, int> JobPostID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.JobPostIsInvalid))
                                        .WithMessage(Lang.JobPostIsInvalid)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.JobPostIsInvalid))
                                        .WithMessage(Lang.JobPostIsInvalid);
            return options;
        }

        public static IRuleBuilder<T, int> JobSectorID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithErrorCode(nameof(Lang.JobSectorNotValid))
                                        .WithMessage(Lang.JobSectorNotValid)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.JobSectorNotValid))
                                        .WithMessage(Lang.JobSectorNotValid);
            return options;
        }

        public static IRuleBuilder<T, int> MoneyID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.moneyIsInvalid))
                                       .WithMessage(Lang.moneyIsInvalid)
                                    .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.moneyIsInvalid))
                                       .WithMessage(Lang.moneyIsInvalid);
            return options;
        }

        public static IRuleBuilder<T, int> OperationTypeID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.OperationTypeIsInvalid))
                                       .WithMessage(Lang.OperationTypeIsInvalid)
                                    .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.OperationTypeIsInvalid))
                                       .WithMessage(Lang.OperationTypeIsInvalid);
            return options;
        }

        public static IRuleBuilder<T, int> PaymentTypeID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.ProviderType_ErrorMustSelect))
                                       .WithMessage(Lang.ProviderType_ErrorMustSelect)
                                    .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.ProviderType_ErrorMustSelect))
                                       .WithMessage(Lang.ProviderType_ErrorMustSelect);
            return options;
        }

        public static IRuleBuilder<T, int> ProviderID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.ProviderIsInvalid))
                                       .WithMessage(Lang.ProviderIsInvalid)
                                    .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.ProviderIsInvalid))
                                       .WithMessage(Lang.ProviderIsInvalid);
            return options;
        }

        public static IRuleBuilder<T, int> ProviderTypeID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.ProviderType_ErrorMustSelect))
                                       .WithMessage(Lang.ProviderType_ErrorMustSelect)
                                    .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.ProviderType_ErrorMustSelect))
                                       .WithMessage(Lang.ProviderType_ErrorMustSelect);
            return options;
        }

        public static IRuleBuilder<T, int> ShopID<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.Shop_ErrorMustSelect))
                                       .WithMessage(Lang.Shop_ErrorMustSelect)
                                    .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.Shop_ErrorMustSelect))
                                       .WithMessage(Lang.Shop_ErrorMustSelect);
            return options;
        }

        public static IRuleBuilder<T, int> SalaryType<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithErrorCode(nameof(Lang.SalaryTypeIsNotValid))
                                       .WithMessage(Lang.SalaryTypeIsNotValid)
                                    .InclusiveBetween(0, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.SalaryTypeIsNotValid))
                                       .WithMessage(Lang.SalaryTypeIsNotValid);
            return options;
        }

        public static IRuleBuilder<T, Guid> UserID<T>(this IRuleBuilder<T, Guid> ruleBuilder)
        {
            var options = ruleBuilder
                         .NotEmpty()
                               .WithMessage(Lang.UserIdIsInvalid)
                               .WithErrorCode(nameof(Lang.UserIdIsInvalid))
                         .NotNull()
                               .WithMessage(Lang.UserIdIsInvalid)
                               .WithErrorCode(nameof(Lang.UserIdIsInvalid))
                          .Must(GuidExtensions.BeAValidGuid)
                               .WithMessage(Lang.UserIdIsInvalid)
                               .WithErrorCode(nameof(Lang.UserIdIsInvalid));
            return options;
        }

        #endregion IdValidators

        #region DecimalValidators

        public static IRuleBuilder<T, decimal> CommissionSale<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.CommissionSaleIsNotValid)
                                        .WithErrorCode(nameof(Lang.CommissionSaleIsNotValid))
                                    .InclusiveBetween(0, decimal.MaxValue)
                                        .WithMessage(Lang.CommissionSaleIsNotValid)
                                        .WithErrorCode(nameof(Lang.CommissionSaleIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> CommissionCollection<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.CommissionCollectionIsNotValid)
                                       .WithErrorCode(nameof(Lang.CommissionCollectionIsNotValid))
                                    .InclusiveBetween(0, decimal.MaxValue)
                                        .WithMessage(Lang.CommissionCollectionIsNotValid)
                                        .WithErrorCode(nameof(Lang.CommissionCollectionIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> CommissionPercent<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.CommissionPercentIsNotValid)
                                       .WithErrorCode(nameof(Lang.CommissionPercentIsNotValid))
                                    .InclusiveBetween(0, decimal.MaxValue)
                                        .WithMessage(Lang.CommissionPercentIsNotValid)
                                        .WithErrorCode(nameof(Lang.CommissionPercentIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> Exchange<T>(this IRuleBuilder<T, decimal> ruleBuilder, decimal minimunValue)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.ExchangeIsnotValid)
                                       .WithErrorCode(nameof(Lang.ExchangeIsnotValid))
                                    .InclusiveBetween(minimunValue, decimal.MaxValue)
                                        .WithMessage(Lang.ExchangeIsnotValid)
                                        .WithErrorCode(nameof(Lang.ExchangeIsnotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> Salary<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.SalaryIsNotValid)
                                        .WithErrorCode(nameof(Lang.SalaryIsNotValid))
                                    .InclusiveBetween(0, decimal.MaxValue)
                                        .WithMessage(Lang.SalaryIsNotValid)
                                        .WithErrorCode(nameof(Lang.SalaryIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> TaxRate<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.TaxRateIsNotValid)
                                        .WithErrorCode(nameof(Lang.TaxRateIsNotValid))
                                    .InclusiveBetween(0, int.MaxValue)
                                        .WithMessage(Lang.TaxRateIsNotValid)
                                        .WithErrorCode(nameof(Lang.TaxRateIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> TotalIva<T>(this IRuleBuilder<T, decimal> ruleBuilder, decimal minimunValue)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.TotalIvaIsNotValid)
                                        .WithErrorCode(nameof(Lang.TotalIvaIsNotValid))
                                    .InclusiveBetween(minimunValue, decimal.MaxValue)
                                        .WithMessage(Lang.TotalIvaIsNotValid)
                                        .WithErrorCode(nameof(Lang.TotalIvaIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> TotalExenta<T>(this IRuleBuilder<T, decimal> ruleBuilder, decimal minimunValue)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.TotalExentaIsNotValid)
                                        .WithErrorCode(nameof(Lang.TotalExentaIsNotValid))
                                    .InclusiveBetween(minimunValue, decimal.MaxValue)
                                        .WithMessage(Lang.TotalExentaIsNotValid)
                                        .WithErrorCode(nameof(Lang.TotalExentaIsNotValid));
            return options;
        }

        public static IRuleBuilder<T, decimal> TotalNeto<T>(this IRuleBuilder<T, decimal> ruleBuilder, decimal minimunValue)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.TotalNetIsInvalid)
                                        .WithErrorCode(nameof(Lang.TotalNetIsInvalid))
                                    .InclusiveBetween(minimunValue, decimal.MaxValue)
                                        .WithMessage(Lang.TotalNetIsInvalid)
                                        .WithErrorCode(nameof(Lang.TotalNetIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, decimal> TotalGravada<T>(this IRuleBuilder<T, decimal> ruleBuilder, decimal minimunValue)
        {
            var options = ruleBuilder.NotNull()
                                       .WithMessage(Lang.TotalGravadaIsNotValid)
                                        .WithErrorCode(nameof(Lang.TotalGravadaIsNotValid))
                                    .InclusiveBetween(minimunValue, decimal.MaxValue)
                                        .WithMessage(Lang.TotalGravadaIsNotValid)
                                        .WithErrorCode(nameof(Lang.TotalGravadaIsNotValid));
            return options;
        }

        #endregion DecimalValidators

        #region IntegerValidators

        public static IRuleBuilder<T, long> InvoiceNumber<T>(this IRuleBuilder<T, long> ruleBuilder, long minimunValue)
        {
            var options = ruleBuilder.NotNull()
                                        .WithMessage(Lang.InvoiceNumberIsNotValid)
                                        .WithErrorCode(nameof(Lang.InvoiceNumberIsNotValid))
                                    .InclusiveBetween(minimunValue, long.MaxValue)
                                        .WithMessage(Lang.InvoiceNumberIsNotValid)
                                        .WithErrorCode(nameof(Lang.InvoiceNumberIsNotValid));
            return options;
        }

        #endregion IntegerValidators

        #region Datetime

        public static IRuleBuilder<T, DateTime> BirthDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            var options = ruleBuilder.NotEmpty()
                                     .WithMessage(Lang.BirthDateIsInvalid)
                                     .WithErrorCode(nameof(Lang.BirthDateIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, DateTime> WorkStartDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            var options = ruleBuilder.NotEmpty()
                                     .WithMessage(Lang.WorkStartDateIsInvalid)
                                     .WithErrorCode(nameof(Lang.WorkStartDateIsInvalid));
            return options;
        }

        public static IRuleBuilder<T, DateTime> PurchaseDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            var startdate = DateTime.UtcNow.AddYears(-100);
            var enddate = DateTime.UtcNow.AddYears(100);
            var options = ruleBuilder.NotEmpty()
                                            .WithMessage(Lang.PurchaseDateIsInvalid)
                                            .WithErrorCode(nameof(Lang.PurchaseDateIsInvalid))
                                      .InclusiveBetween(startdate, enddate)
                                            .WithMessage(Lang.PurchaseDateIsInvalid)
                                            .WithErrorCode(nameof(Lang.PurchaseDateIsInvalid));
            return options;
        }


        public static IRuleBuilder<T, DateTime> PaymentDate<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            var startdate = DateTime.UtcNow.AddYears(-100);
            var enddate = DateTime.UtcNow.AddYears(100);
            var options = ruleBuilder.NotEmpty()
                                            .WithMessage(Lang.PaymentDateIsInvalid)
                                            .WithErrorCode(nameof(Lang.PaymentDateIsInvalid))
                                      .InclusiveBetween(startdate, enddate)
                                            .WithMessage(Lang.PaymentDateIsInvalid)
                                            .WithErrorCode(nameof(Lang.PaymentDateIsInvalid));
            return options;
        }


        #endregion Datetime

        #region Boolean

        public static IRuleBuilder<T, bool> Status<T>(this IRuleBuilder<T, bool> ruleBuilder)
        {
            var options = ruleBuilder.NotNull()
                                        .WithMessage(Lang.StatusIsInvalid)
                                        .WithErrorCode(nameof(Lang.StatusIsInvalid))
                                     .NotEmpty()
                                         .WithMessage(Lang.StatusIsInvalid)
                                         .WithErrorCode(nameof(Lang.StatusIsInvalid));
            return options;
        }

        #endregion Boolean

        #region Generics

        public static IRuleBuilder<T, byte> Generic<T>(this IRuleBuilder<T, byte> ruleBuilder, byte minValue, byte maxValue,
                                                                                string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .InclusiveBetween(minValue, maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, short> Generic<T>(this IRuleBuilder<T, short> ruleBuilder, short minValue, short maxValue,
                                                                                string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .InclusiveBetween(minValue, maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, int> Generic<T>(this IRuleBuilder<T, int> ruleBuilder, int minValue, int maxValue,
                                                                                string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .InclusiveBetween(minValue, maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, long> Generic<T>(this IRuleBuilder<T, long> ruleBuilder, long minValue, long maxValue,
                                                                               string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                    .InclusiveBetween(minValue, maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, List<int>> Generic<T>(this IRuleBuilder<T, List<int>> ruleBuilder, int minValue,
                                                                                        string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                         .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .Must(x => x.Count > minValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, List<long>> Generic<T>(this IRuleBuilder<T, List<long>> ruleBuilder, int minValue,
                                                                                        string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                         .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .Must(x => x.Count > minValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, DateTime> Generic<T>(this IRuleBuilder<T, DateTime> ruleBuilder, string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;
            var startdate = DateTime.UtcNow.AddYears(-100);
            var enddate = DateTime.UtcNow.AddYears(100);
            var options = ruleBuilder.NotNull()
                                            .WithMessage(message)
                                            .WithErrorCode(errorCode)
                                      .NotEmpty()
                                            .WithMessage(message)
                                            .WithErrorCode(errorCode)
                                      .InclusiveBetween(startdate, enddate)
                                            .WithMessage(message)
                                            .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, string> Generic<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                                            int minimumLength,
                                                                            int maximumLength,
                                                                            string message,
                                                                            string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;
            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                 .MinimumLength(minimumLength)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                  .MaximumLength(maximumLength)
                                         .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, bool> Generic<T>(this IRuleBuilder<T, bool> ruleBuilder, string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;
            //var options = ruleBuilder.NotNull()
            //                            .WithMessage(message)
            //                            .WithErrorCode(errorCode)
            //                         .NotEmpty()
            //                             .WithMessage(message)
            //                             .WithErrorCode(errorCode);

            var opt = ruleBuilder.Must(x => !x || x == true).WithMessage(message).WithErrorCode(errorCode);

            return opt;
        }

        public static IRuleBuilder<T, decimal> Generic<T>(this IRuleBuilder<T, decimal> ruleBuilder, decimal minimunValue,
                                                                                  decimal maxValue, string message,
                                                                                  string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;
            var options = ruleBuilder.NotNull()
                                       .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                    .InclusiveBetween(minimunValue, maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, Guid> Generic<T>(this IRuleBuilder<T, Guid> ruleBuilder, string message, string errorCode)
        {
            var options = ruleBuilder
                         .NotEmpty()
                               .WithMessage(message)
                               .WithErrorCode(errorCode)
                         .NotNull()
                               .WithMessage(message)
                               .WithErrorCode(errorCode)
                          .Must(GuidExtensions.BeAValidGuid)
                               .WithMessage(message)
                               .WithErrorCode(errorCode);
            return options;
        }

        #endregion Generics

        #region StringToOthers

        public static IRuleBuilder<T, string> StringIsDecimal<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                                                     decimal minValue, decimal maxValue,
                                                                                    string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var sdds = ruleBuilder.IsDecimals();

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                      .NotEmpty()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .Must(x => decimal.TryParse(x, out var valid) && valid >= minValue && valid <= maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, string> StringIsInteger<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                                    int minValue, int maxValue,
                                                                   string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                      .NotEmpty()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .Must(x => int.TryParse(x, out var valid) && valid >= minValue && valid <= maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, string> StringIsLong<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                                     long minValue, long maxValue,
                                                                  string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                      .NotEmpty()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .Must(x => long.TryParse(x, out var valid) && valid >= minValue && valid <= maxValue)
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        public static IRuleBuilder<T, string> StringIsDateTime<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                                  string message, string errorCode)
        {
            errorCode = string.IsNullOrEmpty(errorCode) ? "error code 01" : errorCode;

            var options = ruleBuilder.NotNull()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                      .NotEmpty()
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode)
                                     .Must(x => DateTime.TryParse(x, CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal, out var newValue))
                                        .WithMessage(message)
                                        .WithErrorCode(errorCode);
            return options;
        }

        #endregion StringToOthers
    }
}