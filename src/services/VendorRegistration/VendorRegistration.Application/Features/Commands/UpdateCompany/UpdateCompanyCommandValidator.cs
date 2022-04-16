using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRegistration.Application.Features.Commands.UpdateCompany
{
    public class UpdateCompanyCommandValidator : AbstractValidator<UpdateCompanyCommand>
    {
        public UpdateCompanyCommandValidator()
        {

            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("{CompanyName} Cannot be Empty")
                .NotNull()
                .MaximumLength(200).WithMessage("{CompanyName} must not exceed 200 characters.");


            RuleFor(c => c.CommercialRegistrationNo).NotEmpty().WithMessage("{CommercialRegistrationNo} Cannot be Empty")
                           .NotNull()
                           .MaximumLength(100).WithMessage("{CommercialRegistrationNo} must not exceed 100 characters.");


            RuleFor(c => c.Language).NotEmpty().WithMessage("{Language} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.Country).NotEmpty().WithMessage("{Country} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.Region).NotEmpty().WithMessage("{Region} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.District).NotEmpty().WithMessage("{District} Cannot be Empty")
                                      .NotNull();
            //RuleFor(c => c.PostalCode).NotEmpty().WithMessage("{PostalCode} Cannot be Empty")
            //                          .NotNull();
            RuleFor(c => c.City).NotEmpty().WithMessage("{City} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.Street).NotEmpty().WithMessage("{Street} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.HouseNo).NotEmpty().WithMessage("{HouseNo} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.Floor).NotEmpty().WithMessage("{Floor} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.Room).NotEmpty().WithMessage("{Room} Cannot be Empty")
                                      .NotNull();
            RuleFor(c => c.POBox).NotEmpty().WithMessage("{POBox} Cannot be Empty")
                                     .NotNull();
            RuleFor(c => c.PhoneNo).NotEmpty().WithMessage("{PhoneNo} Cannot be Empty")
                                     .NotNull();
            RuleFor(c => c.FaxNumber).NotEmpty().WithMessage("{FaxNumber} Cannot be Empty")
                                     .NotNull();
            RuleFor(c => c.Email).NotEmpty().WithMessage("{Email} Cannot be Empty")
                                       .NotNull();
            RuleFor(c => c.MobileNo).NotEmpty().WithMessage("{MobileNo} Cannot be Empty")
                                     .NotNull();
            RuleFor(c => c.Website).NotEmpty().WithMessage("{Website} Cannot be Empty")
                                    .NotNull();
            RuleFor(c => c.VendorType).NotEmpty().WithMessage("{VendorType} Cannot be Empty")
                                    .NotNull();
            RuleFor(c => c.AccountGroup).NotEmpty().WithMessage("{AccountGroup} Cannot be Empty")
                                    .NotNull();
            RuleFor(c => c.Notes).NotEmpty().WithMessage("{Notes} Cannot be Empty")
                                    .NotNull();
            RuleFor(c => c.VatNo).NotEmpty().WithMessage("{VatNo} Cannot be Empty")
                                    .NotNull();
            RuleFor(c => c.DocumentIDs).NotEmpty().WithMessage("{DocumentIDs} Cannot be Empty")
                                    .NotNull();

        }
    }
}
