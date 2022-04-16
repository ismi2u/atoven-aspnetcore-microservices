using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRegistration.Application.Features.Commands.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
