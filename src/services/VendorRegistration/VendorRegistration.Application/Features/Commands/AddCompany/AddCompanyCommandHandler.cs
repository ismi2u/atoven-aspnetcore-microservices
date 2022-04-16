using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Application.Contracts.Infrastructure;
using VendorRegistration.Application.Contracts.Persistence;
using VendorRegistration.Application.Models;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.Application.Features.Commands.AddCompany
{
    public class AddCompanyCommandHandler : IRequestHandler<AddCompanyCommand, Guid>
    {

        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<AddCompanyCommandHandler> _logger;

        //constructor
        public AddCompanyCommandHandler(ICompanyRepository companyRepository, 
                                        IMapper mapper, 
                                        IEmailService emailService, 
                                        ILogger<AddCompanyCommandHandler> logger)
                                {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<Guid> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            var companyEntity = _mapper.Map<Company>(request);
            var newCompany = await _companyRepository.AddAsync(companyEntity);

            _logger.LogInformation($"Company {newCompany.Id} is created successfully");
            await Sendmail(newCompany);

            return newCompany.Id;
        }

        private async Task Sendmail(Company newCompany)
        {
            var email = new Email()
            {
                To = newCompany.Email,
                Subject = "Your Vendor Application Registered!",
                Body = "Your " + newCompany.CompanyName + " is now a Registered Vendor!"
            };

            try
            {
                await _emailService.SendEmailAsync(email);
            }
            catch (Exception)
            {

                _logger.LogError($"Company {newCompany.Id} Email failed!");
            }

          
        }
    }
}
