using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.Application.Contracts.Persistence
{
    public interface ICompanyRepository: IAsyncRepository<Company>
    {

        Task<IEnumerable<Company>> GetCompanyByCompanyName(string CompanyName);

        Task<Company> GetCompanyByCompanyID(Guid CompanyId);

    }
}
