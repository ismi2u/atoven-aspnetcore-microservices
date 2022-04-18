using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Application.Contracts.Persistence;
using VendorRegistration.Domain.Entities;
using VendorRegistration.Infrastructure.Persistence;

namespace VendorRegistration.Infrastructure.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {

        public CompanyRepository(CompanyContext dbContext) : base(dbContext)
        {
        }

        public async  Task<Company> GetCompanyByCompanyID(Guid CompanyId)
        {
           var getCompany = await _dbContext.Companies.FindAsync(CompanyId);

            return getCompany;
        }

        public async Task<IEnumerable<Company>> GetCompanyByCompanyName(string CompanyName)
        {
            var companyList = await _dbContext.Companies.Where(c => c.CompanyName == CompanyName).ToListAsync();

            return companyList;
        }
    }
}
