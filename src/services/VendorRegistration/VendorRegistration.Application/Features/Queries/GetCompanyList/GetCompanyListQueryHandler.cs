using AutoMapper;
using MediatR;
using VendorRegistration.Application.Contracts.Persistence;

namespace VendorRegistration.Application.Features.Queries.GetCompanyList
{
    public class GetCompanyListQueryHandler : IRequestHandler<GetCompanyListQuery, List<CompanyDTO>>
    {

        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyListQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

       


        public async Task<List<CompanyDTO>> Handle(GetCompanyListQuery request, CancellationToken cancellationToken)
        {
           var companylist =  await _companyRepository.GetAllAsync();

          return _mapper.Map<List<CompanyDTO>>(companylist);
        }
    }
}
