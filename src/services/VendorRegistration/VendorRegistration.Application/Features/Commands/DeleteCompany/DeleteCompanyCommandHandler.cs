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

namespace VendorRegistration.Application.Features.Commands.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<DeleteCompanyCommandHandler> _logger;

        public DeleteCompanyCommandHandler(ICompanyRepository companyRepository,
                                            IMapper mapper,
                                            IEmailService emailService,
                                            ILogger<DeleteCompanyCommandHandler> logger)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var companyToDelete = await _companyRepository.GetCompanyByCompanyID(request.Id);

            if (companyToDelete == null)
            {
                _logger.LogError($"Company doesn't exist in the database!");
                throw new NotFoundException(nameof(Company), request.Id);
            }


            _mapper.Map(request, companyToDelete, typeof(DeleteCompanyCommand), typeof(Company));

            await _companyRepository.UpdateAsync(companyToDelete);

            _logger.LogInformation($"Company {companyToDelete.Id} deleted successfully!");

            return Unit.Value;

        }
    }
}
