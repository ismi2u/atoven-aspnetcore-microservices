using AutoMapper;
using MediatR;
using VendorRegistration.Application.Contracts.Persistence;

namespace VendorRegistration.Application.Features.Queries.GetCompanyById
{
    public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyDTO>
    {

        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyByIdQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<CompanyDTO> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.GetCompanyByCompanyID(request.CompanyId);
            return _mapper.Map<CompanyDTO>(company);
        }
    }
}
