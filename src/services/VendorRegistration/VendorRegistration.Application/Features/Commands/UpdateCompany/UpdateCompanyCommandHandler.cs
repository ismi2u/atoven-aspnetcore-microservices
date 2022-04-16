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
using VendorRegistration.Application.Exceptions;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.Application.Features.Commands.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand>
    {

        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<UpdateCompanyCommandHandler> _logger;

        public UpdateCompanyCommandHandler(ICompanyRepository companyRepository, 
                                            IMapper mapper, 
                                            IEmailService emailService, 
                                            ILogger<UpdateCompanyCommandHandler> logger)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
           var updateCompany = await _companyRepository.GetCompanyByCompanyID(request.Id);

            if (updateCompany == null)
            {
                _logger.LogError($"Company {request.Id} doesn't exist in the database!");
                throw new NotFoundException(nameof(Company), request.Id);
            }


            _mapper.Map(request, updateCompany, typeof(UpdateCompanyCommand), typeof(Company));

            await _companyRepository.UpdateAsync(updateCompany);

            _logger.LogInformation($"Company {updateCompany.Id} Details updated!");


            return Unit.Value;
        }
    }
}
