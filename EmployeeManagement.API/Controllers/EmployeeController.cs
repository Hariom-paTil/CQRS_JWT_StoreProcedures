using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Employee.Commands;
using EmployeeManagement.Application.Employee.queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(
            IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var result =
                await _mediator.Send(
                    new GetEmployeesQuery());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(
            int id)
        {
            var result =
                await _mediator.Send(
                    new GetEmployeeByIdQuery(id));

            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(
            CreateEmployeeDto dto)
        {
            await _mediator.Send(
                new CreateEmployeeCommand(dto));

            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(
            UpdateEmployeeDto dto)
        {
            await _mediator.Send(
                new UpdateEmployeeCommand(dto));

            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(
            int id)
        {
            await _mediator.Send(
                new DeleteEmployeeCommand(id));

            return Ok();
        }
    }
}
