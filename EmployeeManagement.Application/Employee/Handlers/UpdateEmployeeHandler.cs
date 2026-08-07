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
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, bool>
    {
        private readonly IEmployeeService _service;

        public UpdateEmployeeHandler(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<bool> Handle(
            UpdateEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            await _service.UpdateEmployee(request.Employee);

            return true;
        }

    }
}
