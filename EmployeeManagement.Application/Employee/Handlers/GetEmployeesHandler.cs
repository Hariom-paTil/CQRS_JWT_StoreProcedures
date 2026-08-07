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
    public  class GetEmployeesHandler : IRequestHandler<GetEmployeesQuery, List<EmployeeDto>>
    {
        private readonly IEmployeeService _service;

        public GetEmployeesHandler(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<List<EmployeeDto>> Handle(
            GetEmployeesQuery request,
            CancellationToken cancellationToken)
        {
            return await _service.GetEmployees();
        }

    }
}
