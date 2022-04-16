using MediatR;

namespace VendorRegistration.Application.Features.Queries.GetCompanyList
{
    public class GetCompanyListQuery : IRequest<List<CompanyDTO>>
    {
        public GetCompanyListQuery()
        {

        }

    }
}
