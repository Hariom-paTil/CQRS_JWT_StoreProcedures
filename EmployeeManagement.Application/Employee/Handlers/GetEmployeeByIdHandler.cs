using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Employee.queries;
using EmployeeManagement.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Employee.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
    {
        private readonly IEmployeeService _service;

        public GetEmployeeByIdHandler(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<EmployeeDto> Handle(
            GetEmployeeByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _service.GetEmployeeById(request.Id);
        }
    }
}
