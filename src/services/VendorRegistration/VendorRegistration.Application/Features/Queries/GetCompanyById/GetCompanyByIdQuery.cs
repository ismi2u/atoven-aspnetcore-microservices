

using MediatR;

namespace VendorRegistration.Application.Features.Queries.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<CompanyDTO>
    {

        public Guid CompanyId { get; set; }

        public GetCompanyByIdQuery(Guid companyId)
        {
            CompanyId = companyId;
        }
    }
}
