using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VendorRegistration.Application.Features.Commands.AddCompany;
using VendorRegistration.Application.Features.Commands.DeleteCompany;
using VendorRegistration.Application.Features.Commands.UpdateCompany;
using VendorRegistration.Application.Features.Queries.GetCompanyById;
using VendorRegistration.Application.Features.Queries.GetCompanyList;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetCompanies")]
        [ProducesResponseType(typeof(IEnumerable<Company>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanyList()
        {
            var query = new GetCompanyListQuery();
            var listCompany = await _mediator.Send(query);
            return Ok(listCompany);
        }

        [HttpGet("{compId}", Name = "GetCompanyById")]
        [ProducesResponseType(typeof(Company), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Company>> GetCompanyById(Guid compId)
        {
            var query = new GetCompanyByIdQuery(compId);
            var company = await _mediator.Send(query);
            return Ok(company);
        }


        [HttpPost( Name = "RegisterCompany")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> RegisterCompany([FromBody] AddCompanyCommand command)
        {

           var result = _mediator.Send(command);
            return Ok(result);
        }


        [HttpPut(Name = "UpdateCompany")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> UpdateCompany([FromBody] UpdateCompanyCommand command)
        {

            var result =  _mediator.Send(command);
            return NoContent();
        }


        [HttpDelete("{Id}", Name = "DeleteCompany")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> DeleteCompany(Guid id)
        {
            var command = new DeleteCompanyCommand() { Id = id};
            var result = _mediator.Send(command);
            return NoContent();
        }

    }
}
