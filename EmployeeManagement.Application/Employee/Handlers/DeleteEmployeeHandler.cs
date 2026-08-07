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
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IEmployeeService _service;

        public DeleteEmployeeHandler(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<bool> Handle(
            DeleteEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            await _service.DeleteEmployee(request.Id);

            return true;
        }
    }
}
