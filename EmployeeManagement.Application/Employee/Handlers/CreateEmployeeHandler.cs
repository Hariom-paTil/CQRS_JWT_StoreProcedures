using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Employee.Commands;
using EmployeeManagement.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Employee.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, bool>
    {
        private readonly IEmployeeService _service;

        public CreateEmployeeHandler(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<bool> Handle(
            CreateEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            await _service.AddEmployee(request.Employee);

            return true;
        }
    }
}
