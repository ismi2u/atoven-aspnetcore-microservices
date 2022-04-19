using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.Infrastructure.Persistence
{
    public class CompanyContextSeed
    {

        public static async Task SeedAsync(CompanyContext companyContext, ILogger<CompanyContextSeed> logger)
        {

            if (!companyContext.Companies.Any())
            {
                companyContext.Companies.AddRange(GetPreconfiguredCompanies());

                await companyContext.SaveChangesAsync();
            }
        }

        private static IEnumerable<Company> GetPreconfiguredCompanies()
        {
            return new List<Company>
            {

               new Company 
               {
                Id = Guid.NewGuid(),
                CompanyName = "GAJ(MIDDLEEAST)ARCHITECTURAL&CIVIL",
                CommercialRegistrationNo = "CRNO100110",
                Language = "En",
                Email = "ismailkhanf@gmail.com"
               
               },


                new Company
                {
                    Id = Guid.NewGuid(),
                    CompanyName = "TESTCOMPANY2",
                    CommercialRegistrationNo = "CRNO100111",
                    Language = "Ar",
                    Email = "ismailkhanf@gmail.com"
                }
        };


        }
    }
}
