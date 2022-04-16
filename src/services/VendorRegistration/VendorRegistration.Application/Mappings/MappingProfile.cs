using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Application.Features.Commands.AddCompany;
using VendorRegistration.Application.Features.Commands.DeleteCompany;
using VendorRegistration.Application.Features.Commands.UpdateCompany;
using VendorRegistration.Application.Features.Queries;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.Application.Mappings
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Company, AddCompanyCommand>().ReverseMap();
            CreateMap<Company, UpdateCompanyCommand>().ReverseMap();
            CreateMap<Company, DeleteCompanyCommand>().ReverseMap();
        }
    }
}
